using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Client
{
    public static class ExchangeRates
    {
        public static int ID { get; set; }
        public static double USD { get; set; }
        public static double GBP { get; set; }
        public static double EUR { get; set; }
        public static double CNY { get; set; }
        public static double CZK { get; set; }
        public static double BTC { get; set; }
        public static double ETH { get; set; }
        public static double BCH { get; set; }
        public static double XRP { get; set; }
        public static double USDT { get; set; }
        public static double USDD { get; set; }
        public static double BNB { get; set; }
        public static double DOGE { get; set; }
        public static double LINK { get; set; }
        public static double CHZ { get; set; }
        public static double DOT { get; set; }

        public static void UpdateRates(RatesResponse res)
        {
            // usd
            USD = 1;
            USDT = res.USDT; 
            USDD = USDT;
            // GBP
            GBP = res.GBP;
            // EUR
            EUR = res.EUR;
            // CNY
            CNY = res.CNY;
            // CZK
            CZK = res.CZK;
            // BTC
            BTC = res.BTC;
            // ETH
            ETH = res.ETH;
            // BCH
            BCH = res.BCH;
            // XRP
            XRP = res.XRP;
            // BNB
            BNB = res.BNB;
            // DOGE
            DOGE = res.DOGE;
            // LINK
            LINK = res.LINK;
            // CHZ
            CHZ = res.CHZ;
            // DOT
            DOT = res.DOT;
        }
        public static double ToUSDRate(this string currency)
        {
            double ret = USD;
            if(currency == nameof(GBP))ret = GBP;
            else if(currency == nameof(EUR))ret = EUR;
            else if(currency == nameof(CNY))ret = CNY;
            else if(currency == nameof(CZK))ret = CZK;
            else if(currency == nameof(BTC))ret = BTC;
            else if(currency == nameof(ETH))ret = ETH;
            else if(currency == nameof(BCH))ret = BCH;
            else if(currency == nameof(XRP))ret = XRP;
            else if(currency == nameof(USDT))ret = USDT;
            else if(currency == nameof(USDD))ret = USDD;
            else if(currency == nameof(BNB))ret = BNB;
            else if(currency == nameof(DOGE))ret = DOGE;
            else if(currency == nameof(LINK))ret = LINK;
            else if(currency == nameof(CHZ))ret = CHZ;
            else if(currency == nameof(DOT))ret = DOT;
            return ret;
        } 
        
        public static double CoinToMoney(this string coin, double amount, string currency)
        {
            double curr_usd = currency.ToUSDRate();
            double coin_usd = coin.ToUSDRate() * amount;
            double ret = coin_usd / curr_usd;
            if(double.IsNaN(ret))ret = 0;
            return ret;
        }
    }

    public class ExchangeRatesResponse
    {
        public string asset_id_base { get; set; }
        public List<Rates> rates { get; set; }
    }
    public class Rates
    {
        public DateTime time { get; set; }
        public string asset_id_quote { get; set; }
        public double rate { get; set; }
    }
}