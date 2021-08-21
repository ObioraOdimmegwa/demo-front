using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;

namespace Client
{
    public static class HelperExtensions
    {
        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];

            var jsonBytes = ParseBase64WithoutPadding(payload);

            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));
            return claims;
        }
        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }

        public static double ToCoinFormat(this double coin)
        {
            return Math.Round(coin, 5);
        }
        public static double ToMoneyFormat(this double money)
        {
            return Math.Round(money, 2);
        }
        public static double AvailableBalance(this UserWallet wallet)
        {
            string c = wallet.Currency;
            double ret = "BCH".CoinToMoney(wallet.BCH, c) + "BNB".CoinToMoney(wallet.BNB, c)
                + "BTC".CoinToMoney(wallet.BTC, c) + "CHZ".CoinToMoney(wallet.CHZ, c)
                + "DOGE".CoinToMoney(wallet.DOGE, c) + "DOT".CoinToMoney(wallet.DOGE, c)
               + "ETH".CoinToMoney(wallet.ETH, c)
                + "LINK".CoinToMoney(wallet.LINK, c) + "USDD".CoinToMoney(wallet.USDD, c)
                + "USDT".CoinToMoney(wallet.USDT, c) + "XRP".CoinToMoney(wallet.XRP, c);
            if (double.IsNaN(ret)) ret = 0;
            return ret;
        }
        public static string GetShortFormat(this DateTime time)
        {
            return time.Month.GetShorMonth() + " " + time.Day + "," + time.Year.ToString();
        }
        public static string GetShorMonth(this int month)
        {
            return month == 1 ? "Jan" :
                month == 2 ? "Feb" :
                month == 3 ? "Mar" :
                month == 4 ? "Apr" :
                month == 5 ? "May" :
                month == 6 ? "Jun" :
                month == 7 ? "Jul" :
                month == 8 ? "Aug" :
                month == 9 ? "Sep" :
                month == 10 ? "Oct" :
                month == 11 ? "Nov" : "Dec";
        }
    }
}