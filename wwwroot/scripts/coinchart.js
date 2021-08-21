function CoinChart() {}

CoinChart.init = function(fromSymbol, fromShowSymbol, fromShortSymbol, prefSymbol, prefShortSymbol) {
    CoinChart.fromSymbol = fromSymbol;
    CoinChart.fromShowSymbol = fromShowSymbol;
    CoinChart.fromShortSymbol = fromShortSymbol;
    CoinChart.prefSymbol = prefSymbol;
    CoinChart.prefShortSymbol = prefShortSymbol;
    Highcharts.setOptions({
        global: {
            useUTC: false
        }
    });
    CoinChart.chartType = null;
    CoinChart.isLog = false;
    CoinChart.chartShowsAvg = true;
    CoinChart.chartSelectLast = $('#chart-select option:selected').val();
    $('#log-chart-switch').change(function() {
        var chart = $('#historical-chart').highcharts();
        if (!chart) return;
        if (this.checked) {
            CoinChart.isLog = true;
            chart.update({yAxis: [{type: 'logarithmic'}, {type: 'linear',floor: 0}, {type: 'logarithmic'}, {type: 'logarithmic'}]})
            chart.yAxis[3].update({tickPositions:[Math.log10(CoinChart.current_price) ]});
        } else {
            CoinChart.isLog = false;
            chart.update({yAxis: [{type: 'linear'}, {type: 'linear', floor: 0}, {type: 'linear'}, {type: 'linear'}]})
            chart.yAxis[3].update({tickPositions:[CoinChart.current_price]});
        }
    });
    $('#ohlc-chart-switch').change(function() {
        var chart = $('#historical-chart').highcharts();
        if (!chart) return;
        if (this.checked) {
            var need_refresh;
            need_refresh = false;
            if ($('#chart-select option:selected').length > 0) {
                $('#chart-select option:selected').each(function() {
                    if ($(this).val() != CoinChart.chartSelectLast) {
                        need_refresh = true;
                        $("#chart-select").multiselect('deselect', $(this).val());
                    }
                });
                if ($('#chart-select option:selected').length == 0) {
                    $('#chart-select').multiselect('select', -1);
                    CoinChart.chartSelectLast = -1;
                    need_refresh = true;
                }
            }
            chart.series[0].update({type: 'candlestick'}, true);
            CoinChart.chartType = 'candlestick';
            if (need_refresh) CoinChart.select_chart([CoinChart.chartSelectLast]);
        } else {
            CoinChart.chartType = 'area';
            chart.series[0].update({type: 'area'}, true);
        }
        // save preference
        $.ajax({
            type: 'POST',
            url: '/stars',
            data: 'candle=' + (this.checked ? 1 : 0),
            dataType: 'json'
        });

    });
    $('#chart-options-btn').on('click', function(event) {
        $('#chart-options').toggle();
        $('#chart-options').removeClass('d-none');
    });
    $('#chart-select').multiselect({
        buttonClass: 'btn btn-secondary',
        templates: {
            li: '<li><a tabindex="0" class="dropdown-item"><label></label></a></li>',
        },
        enableCaseInsensitiveFiltering: true,
        dropRight: true,
        enableHTML: true,
        maxHeight: 300,
        disabledText: 'Average',
        onChange: function(option, checked, select) {
            if ($('#historical-chart').highcharts().series[0].type == 'candlestick') {
                $("#chart-select").multiselect('select', option.val());
                $("#chart-select").multiselect('deselect', CoinChart.chartSelectLast);
            }
            CoinChart.chartSelectLast = option.val();
            var selected = [];
            var chartshowsavg = false;
            $('#chart-select option:selected').each(function() {
                selected.push($(this).val());
                if ($(this).val() == -1) chartshowsavg = true;
            });
            if (selected.length == 0) {
                $('#chart-select').multiselect('select', -1);
                CoinChart.chartSelectLast = -1;
                CoinChart.select_chart([-1]);
                chartshowsavg = true;
            } else {
                CoinChart.select_chart(selected);
            }
            CoinChart.chartShowsAvg = chartshowsavg;
            CoinChart.live_update_chart(CoinChart.current_price);
        }
    });
}

CoinChart.draw_historic_chart = function(candleView) {
    CoinChart.chartType = candleView ? 'candlestick' : 'area';
    if ($('#historical-chart').length == 0) return;
    $.getJSON('/api/history?f=' + CoinChart.fromSymbol + '&t=' + CoinChart.prefSymbol + '&callback=?', function(data) {
        var price = [];
        var otherprice = [];
        var uts = [];
        var volume = [];
        var minValue = Number.MAX_SAFE_INTEGER;
        var minOtherValue = Number.MAX_SAFE_INTEGER;
        var ix = 0;
        var other_coin_id = data['other'];
        var other_coin_symbol = data['other_symbol'];
        for (var ut in data['data']) {
            d = data['data'][ut];
            uts.push([parseInt(ut)]);
            ix++;
            if (ix == 1) {
                //skip first value (otherwise clicking on all won't reflect a range change)
                continue;
            }
            if (d[-1][0] < minValue) minValue = d[-1][0];
            if (d[-1][0] == "null") {
                price.push([parseInt(ut), null, null, null, null]);
            } else {
                price.push([parseInt(ut), d[-1][2], d[-1][3], d[-1][4], d[-1][0]]);
            }
            volume.push([parseInt(ut), d[-1][1] == "null" ? null : d[-1][1]]);
            if (other_coin_id) {
                otherprice.push([parseInt(ut), d['c' + data['other']][0] == "null" ? null : d['c' + data['other']][0]]);
                if (d['c' + data['other']][0] < minOtherValue) minOtherValue = d['c' + data['other']][0];
            }
        }
        // create the chart
        Highcharts.setOptions({
            lang: {
                rangeSelectorZoom: ''
            }
        });
        Highcharts.stockChart('historical-chart', {
            responsive: {
                rules: [{
                    condition: {
                        maxWidth: 768
                    },
                    chartOptions: {
                        chart: {
                            spacing: [10,0,10,0]
                        }
                    }
                }]
            },
            chart: {
                zoomType: 'x',
                pinchType : 'none',
                events: {
                    load: function() {
                        CoinChart.graph_delta = this.renderer.label('', 7, 40, null, null, null, true).css(
                            {
                                fontSize: '0.8em'
                            }).add();
                        CoinChart.updateGraphCustomLabels(this);
                        CoinChart.live_update_chart(CoinChart.current_price);
                        setInterval(function() { CoinChart.maybeRefreshChart(); }, 30000);
                        if (data['defaultview']) {
                            $($('.highcharts-button.highcharts-button-normal')[1]).find('text').css("font-weight","bold");
                        } else {
                            $('.highcharts-button.highcharts-button-normal').last().find('text').css("font-weight","bold");
                        }
                    }
                }
            },
            credits: {
                enabled: false
            },
            scrollbar: {
                enabled: false,
                liveRedraw: false
            },

            // effective disabled but not really due to highstock bug
            navigator : {
                adaptToUpdatedData: false,
                series : {
                    data : uts
                },
                height: 0,
                xAxis: {
                    labels: {
                        enabled: false
                    }
                },
                handles: {
                    backgroundColor: 'transparent',
                    borderColor: 'transparent'
                },
                outlineWidth: 0
            },
            rangeSelector: {
                buttons: [
                    {
                        type: 'hour',
                        count: 1,
                        text: _t('1h'),
                    }, {
                        type: 'day',
                        count: 1,
                        text: _t('1d'),
                    }, {
                        type: 'day',
                        count: 6,
                        text: _t('7d'),
                    }, {
                        type: 'month',
                        count: 1,
                        text: _t('1m'),
                    }, {
                        type: 'month',
                        count: 3,
                        text: _t('3m'),
                    }, {
                        type: 'month',
                        count: 6,
                        text: _t('6m'),
                    }, {
                        type: 'ytd',
                        count: 1,
                        text: _t('YTD'),
                    }, {
                        type: 'year',
                        count: 1,
                        text: _t('1y'),
                    }, {
                        type: 'all',
                        text: _t('All'),
                    }
                ],
                inputEnabled: true
            },

            xAxis: {
                events: {
                    afterSetExtremes: CoinChart.afterSetExtremes
                },
                gridLineColor: '#eeeeee',
                minRange: 600 * 1000 // 10 minutes
            },

            yAxis: [
                {
                    tickLength: 0,
                    labels: {
                        formatter: function () {
                            return htmlDecode(CoinChart.prefShortSymbol) + format_price(this.value);
                        },
                        align: 'right',
                        x: 0
                    },
                    title: {
                        text: null,
                    },
                    top: '3%',
                    height: '97%',
                    lineWidth: 0,
                    min: minValue,
                    alignTicks: false,
                    startOnTick: false,
                    endOnTick: false,
                    gridLineColor: 'rgba(200, 200, 200, 0.1)',
                }, {
                    visible: false,
                    title: {
                        text: _t('Volume')
                    },
                    top: '65%',
                    height: '35%',
                    offset: 0,
                    min: 0
                }, {
                    gridLineColor: 'rgba(200, 200, 200, 0.1)',
                    visible: true,
                    opposite: false,
                    tickLength: 0,
                    labels: {
                        formatter: function () {
                            return format_price(this.value);
                        },
                        align: 'left',
                        x: 0
                    },
                    title: {
                        text: null,
                    },
                    height: '100%',
                    lineWidth: 0,
                    min: minOtherValue,
                },

                {
                    opposite:true,
                    linkedTo:0,
                    tickLength: 0,
                    tickPositions:[price[price.length - 1][4]],
                    gridLineWidth: 1,
                    gridLineColor: '#2e7ad0',
                    labels: {
                        useHTML: true,
                        align: 'right',
                        x: 0,
                        y: -30,
                        formatter: function() {
                            return '<span style="background-color: #2e7ad0; padding: 2px; color: #fff;border: 1px solid #999999;">' + htmlDecode(CoinChart.prefShortSymbol) + format_price(this.value) + '</span>';
                        }
                    }
                }
            ],

            tooltip: {
                split: true,
                useHTML: true,
                formatter: function () {
                    if ($('#historical-chart').highcharts().series[0].type != 'candlestick') {
                        s = '<table class="tip"><caption>' + Highcharts.dateFormat('%d %b, %Y %H:%M', this.points[0].x) + '</caption><tbody>';
                        for (ix = 0; ix < this.points.length; ++ix) {
                            if (this.points[ix].series.options.id != 'mainvolume') {
                                s += '<tr><td>' + this.points[ix].series.name + ': </td><td>' + htmlDecode(CoinChart.prefShortSymbol) + format_large_number(this.points[ix].y, true) + '</td></tr>';
                            } else if (this.points[ix].series.options.id == 666) {
                                s += '<tr><td>' + this.points[ix].series.name + ' ' + _t('price:') + '</td><td>' + format_price(this.points[ix].y) + '</td></tr>';
                            } else {
                                s += '<tr><td>' + this.points[ix].series.name + ' ' + _t('price:') + ' </td><td>' + htmlDecode(CoinChart.prefShortSymbol) + format_price(this.points[ix].y) + '</td></tr>';
                            }
                        }
                        s += '</tbody></table>';
                    } else {
                        s = '<table class="tip"><caption>' + Highcharts.dateFormat('%d %b, %Y %H:%M', this.points[0].x) + '</caption><tbody>';
                        for (ix = 0; ix < this.points.length; ++ix) {
                            if (this.points[ix].series.options.id != 'mainvolume') {
                                s += '<tr><td>' + this.points[ix].series.name + ': </td><td>' + htmlDecode(CoinChart.prefShortSymbol) + format_large_number(this.points[ix].y, true) + '</td></tr>';
                            } else if (this.points[ix].series.options.id == 666) {
                                s += '<tr><td>' + this.points[ix].series.name + ' ' + _t('price:') + ' </td><td>' + format_price(this.points[ix].y) + '</td></tr>';
                            } else {
                                var yData;
                                if (!this.points[0].series.groupedData && this.points[0].point.open) {
                                    yData = this.points[0].point;
                                } else {
                                    for (var index = 0; index < this.points[0].series.groupedData.length; index++) {
                                        if (this.points[0].series.groupedData[index] != undefined && this.points[0].series.groupedData[index].x == this.points[0].x) break;
                                    }
                                    yData = this.points[0].series.groupedData[index];
                                }
                                if (!yData) return;
                                s += '<tr><td>' + this.points[ix].series.name + ' '+_t('Open:')+' </td><td>' + htmlDecode(CoinChart.prefShortSymbol) + format_price(yData.open) + '</td></tr>';
                                s += '<tr><td>' + this.points[ix].series.name + ' '+_t('High:')+' </td><td>' + htmlDecode(CoinChart.prefShortSymbol) + format_price(yData.high) + '</td></tr>';
                                s += '<tr><td>' + this.points[ix].series.name + ' '+_t('Low:')+' </td><td>' + htmlDecode(CoinChart.prefShortSymbol) + format_price(yData.low) + '</td></tr>';
                                s += '<tr><td>' + this.points[ix].series.name + ' '+_t('Close:')+' </td><td>' + htmlDecode(CoinChart.prefShortSymbol) + format_price(yData.close) + '</td></tr>';
                            }
                        }
                        s += '</tbody></table>';
                    }
                    return s;
                },
            },
            plotOptions: {
                column: {
                    borderColor: 'rgba(132, 184, 235, 0.8)',
                    pointPadding: 0.1,
                    groupPadding: 0.1,
                    color: 'rgba(132, 184, 235, 0.8)',
                    yAxis: 1,
                    stacking: 'normal',
                    showInLegend: false,
                    animation: false,
                    dataGrouping: {
                        enabled: true,
                        groupPixelWidth: 3,
                        approximation: 'sum'
                    }
                },
                area: {
                    animation: false,
                    lineWidth: 1,
                    fillOpacity: 0.3,
                },
                series: {
                    animation: false,
                    lineWidth: 1,
                    dataGrouping: {
                        enabled: true,
                        groupPixelWidth: 3,
                        approximation: 'close'
                    }
                },
                candlestick: {
                    color: 'red',
                    upColor: 'green',
                    lineColor: 'green',
                    upLineColor: 'red',
                    dataGrouping: {
                        enabled: true,
                        groupPixelWidth: 12,
                        approximation: 'ohlc'
                    }
                },
            },
            legend: {
                enabled: true,
                y: 0,
                padding: 0,
                itemMarginBottom:0,
                itemMarginTop:0,
            },
            series: [
                {
                    name: _t('Avg.') + ' ' + CoinChart.fromShowSymbol + CoinChart.prefSymbol,
                    type: candleView ? 'candlestick' : 'area',
                    data: price,
                    zIndex: 2,
                }, {
                    name: _t('Total volume'),
                    type: 'column',
                    data: volume,
                    zIndex: 0,
                    id: 'mainvolume'
                }].concat(other_coin_id ? [{
                    zIndex: 1,
                    id: 666,
                    visible: false,
                    name: _t('Avg.') + ' ' + CoinChart.fromShowSymbol + other_coin_symbol,
                    type: 'area',
                    data: otherprice,
                    fillOpacity: 0,
                    yAxis: 2
                }] : []),
        });
    });
}


CoinChart.select_chart = function(e) {
    CoinChart.exchange = e;
    CoinChart.redraw_historic_chart($('#historical-chart').highcharts().xAxis[0].min,
                                   $('#historical-chart').highcharts().xAxis[0].max);
}

CoinChart.redraw_historic_chart = function(start, end) {
    var chart = $('#historical-chart').highcharts();
    chart.showLoading(_t('Loading...'));
    $.getJSON('/api/history?f=' + CoinChart.fromSymbol + '&t=' + CoinChart.prefSymbol + '&start=' + start +
              '&end=' + end + '&exchange=' + JSON.stringify(CoinChart.exchange) + '&callback=?', function (data) {
                  var chartdata = {};
                  var minValue = Number.MAX_SAFE_INTEGER;
                  var other_coin_symbol = data['other_symbol'];
                  var minValue2 = Number.MAX_SAFE_INTEGER;
                  var ex_count = 0;
                  var disabled_mask = {};
                  for (var ut in data['data']) {
                      for (var ex in data['data'][ut]) {
                          if (chartdata[ex] == undefined) {
                              chartdata[ex] = {0:[], 1:[]};
                              ex_count++;
                          }
                          if ((ex + "").substring(0, 1) != 'c' && data['data'][ut][ex][4] < minValue) minValue = data['data'][ut][ex][4];
                          if ((ex + "").substring(0, 1) == 'c' && data['data'][ut][ex][4] < minValue2) minValue2 = data['data'][ut][ex][4];
                          if (data['data'][ut][ex][0] == "null") {
                              chartdata[ex][0].push([parseInt(ut), null, null, null, null]);
                          } else {
                              chartdata[ex][0].push([parseInt(ut), data['data'][ut][ex][2], data['data'][ut][ex][3],
                                                     data['data'][ut][ex][4], data['data'][ut][ex][0]]);
                          }
                          chartdata[ex][1].push([parseInt(ut), data['data'][ut][ex][1] == "null" ? null : data['data'][ut][ex][1]]);
                      }
                  }
                  var charttype = chart.series[0].type;
                  while(chart.series.length > 0) {
                      if (!chart.series[0].visible) {
                          disabled_mask[chart.series[0].name] = 1;
                      }
                      chart.series[0].remove(true);
                  }

                  exs = Object.keys(chartdata);
                  if (chartdata[-1] != undefined) {
                      exs = ["-1"].concat(exs.filter(function(item) { return item != -1}));
                  }
                  var default_color = true;
                  for (var ix = 0; ix < exs.length; ix++) {
                      if ((exs[ix] + "").substring(0, 1) != 'c' && exs[ix] != -1) default_color = false;
                  }
                  for (var ix = 0; ix < exs.length; ix++) {
                      ex = exs[ix];
                      hasvolume = true;
                      if ((ex + "").substring(0, 1) == 'c') {
                          name = _t('Avg.')+ ' ' + CoinChart.fromShowSymbol + other_coin_symbol;
                          hasvolume = false;
                          if (disabled_mask[name] == undefined) {
                              disabled_mask[name] = true;
                          }
                      } else if (ex == -1) {
                          name = _t('Avg.') + ' ' + CoinChart.fromShowSymbol + CoinChart.prefSymbol;
                      } else {
                          name = window.ALL_EXCHANGES[ex][0];
                      }
                      chart.addSeries({
                          name: name,
                          type: hasvolume ? charttype : 'line',
                          data: chartdata[ex][0],
                          yAxis: hasvolume ? 0 : 2,
                          visible: disabled_mask[name] ? false : true,
                          id: hasvolume ? null : 666,
                          zIndex: charttype == 'candlestick' ? 1 : 0,
                          colorIndex: ix
                      });
                      if (hasvolume) {
                          series = {
                              name: (ex == -1 ? _t('Total') :
                                    window.ALL_EXCHANGES[ex][0]) + ' '+ _t('volume'),
                              type: 'column',
                              data: chartdata[ex][1],
                              zIndex: 0,
                              id: ex == -1 ? 'mainvolume' : null
                          };
                      }
                      if (ex != -1) {
                          var magic = chart.series.length - 1;
                          if (ix == 0) magic = 0;
                          chart.series[magic].update({fillOpacity:0});
                      }
                      if (!default_color && ex_count > 1) {
                          series['color'] = chart.series[chart.series.length - 1].color;
                          series['borderColor'] = chart.series[chart.series.length - 1].color;
                          chart.legend.update({enabled: true});
                      } else {
                          chart.series[chart.series.length - 1].update({fillOpacity:0.2});
                      }
                      if (hasvolume) {
                          chart.addSeries(series);
                      }
                  }
                  chart.yAxis[0].setExtremes(minValue, null);
                  chart.yAxis[2].setExtremes(minValue2, null);
                  chart.hideLoading();
                  CoinChart.updateGraphCustomLabels(chart);
                  CoinChart.live_update_chart(CoinChart.current_price);
              });
}

CoinChart.updateGraphCustomLabels = function(chart) {
    updateGraphCustomLabels(CoinChart.graph_delta, chart, CoinChart.prefShortSymbol);
}

CoinChart.afterSetExtremes = function(e) {
    if (e.dataMin == null || e.dataMax == null ||
        (Math.abs(e.dataMin - e.min) <= 1200000 && Math.abs(e.dataMax - e.max) <= 120000)) {
        return;
    }
    CoinChart.redraw_historic_chart(Math.round(e.min), Math.round(e.max));
}

CoinChart.maybeRefreshChart = function () {
    var now = get_timestamp() * 1000;
    var chart = $('#historical-chart').highcharts();
    if (chart && now - chart.xAxis[0].max < 600 * 1000) {
        // upper bound is within the last 10 minutes, let's ajax refresh the last day's worth of data
        // except the last data point (stream-updated)
        $.getJSON('/api/history?f=' + CoinChart.fromSymbol + '&t=' + CoinChart.prefSymbol + '&callback=?', function (data) {
            var db_values = {};
            for (var ut in data['data']) {
                d = data['data'][ut];
                db_values[parseInt(ut)] = {
                    'ohlc': [parseInt(ut), d[-1][2], d[-1][3], d[-1][4], d[-1][0]],
                    'volume' : [parseInt(ut), d[-1][1] == "null" ? null : d[-1][1]]};
            }
            var cdata = chart.series[0].options.data;
            for (var ix = 0; ix < cdata.length - 1; ix++) {
                if (db_values[cdata[ix][0]] != undefined) {
                    cdata[ix] = db_values[cdata[ix][0]]['ohlc'];
                } else if (ix > 0 && cdata[ix-1][4] != cdata[ix][1]) {
                    // Fix prev-close = new-open
                    cdata[ix][1] = cdata[ix-1][4];
                }
            }
            chart.series[0].setData(cdata, true, true, false);
            if (chart.get('mainvolume') != undefined) {
                var vdata = chart.get('mainvolume').options.data;
                for (var ix = 0; ix < vdata.length; ix++) {
                    if (db_values[vdata[ix][0]] != undefined) {
                        vdata[ix] = db_values[vdata[ix][0]]['volume'];
                    }
                }
                chart.get('mainvolume').setData(vdata, true, true, false);
            }
        });
    }
}

CoinChart.live_update_chart = function(price) {
    if (price == undefined) return;
    CoinChart.current_price = price;
    var now = get_timestamp() * 1000;
    var chart = $('#historical-chart').highcharts();
    if (chart && now - chart.xAxis[0].max < 600 * 1000 && CoinChart.chartShowsAvg) {
        var cdata;
        cdata = chart.series[0].options.data;
        // pad price data until now:
        last_ut = cdata[cdata.length - 1][0];
        last_ut_price = cdata[cdata.length - 1][4]
        now_ut = now - (now % 60000);
        var padded = false;
        while (last_ut < now_ut) {
            // padding..
            last_ut += 60000;
            cdata.push([last_ut, last_ut_price, last_ut_price, last_ut_price, last_ut_price]);
            padded = true;
        }

        // pad volume data until now:
        if (chart.get('mainvolume') != undefined) {
            var vdata = chart.get('mainvolume').options.data;
            vlast_ut = vdata[vdata.length - 1][0];
            var vpadded = false;
            while (vlast_ut < now_ut) {
                // padding..
                vlast_ut += 60000;
                vdata.push([vlast_ut, null])
                vpadded = true;
            }
            if (vpadded) {
                chart.get('mainvolume').setData(vdata, true, true, false);
            }
        }

        if (CoinChart.chartType == 'area') {
            cdata[cdata.length - 1][1] = price;
        } else if (cdata.length > 1) {
            // Fix close-open
            cdata[cdata.length - 1][1] = cdata[cdata.length - 2][4];
        }
        // update with latest price data
        price = parseFloat(price);
        cdata[cdata.length - 1][2] = Math.max(price, cdata[cdata.length - 1][2]);
        cdata[cdata.length - 1][3] = Math.min(price, cdata[cdata.length - 1][3]);
        cdata[cdata.length - 1][4] = price;

        chart.yAxis[3].update({tickPositions:[CoinChart.isLog ? Math.log10(price) : price]});
        chart.series[0].setData(cdata, true, true, false);
        if (price < chart.yAxis[0].getExtremes().min) {
            chart.yAxis[0].setExtremes(price * 0.999, null);
        }
        if (padded) {
            chart.xAxis[0].setExtremes(chart.xAxis[0].min, now_ut);
        }
    } else if (chart) {
        chart.yAxis[3].update({tickPositions:[null]});
    }
    CoinChart.updateGraphCustomLabels(chart);
}
