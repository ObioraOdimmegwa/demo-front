namespace Client
{
    public class Response { }
    public class Response<T> : Response
    {
        public T Data { get; set; }
    }
    public class ErrorResponse : Response
    {
        public string ErrorMessage { get; set; }
    }
    public class LoginResponse : Response
    {
        public string Token { get; set; }
        public string TwoFactorCode { get; set; }
    }

    public class LoginRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class Login2AuthRequest
    {
        public string email { get; set; }
        public string token { get; set; }
    }

    public class TransactionUploadRequest
    {
        public double Amount { get; set; }
        public string Type { get; set; }
        public string Currency { get; set; }
        public string Coin { get; set; }
    }
    public class TransactionResponse
    {
        public string Id { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string Coin { get; set; }
        public string Type { get; set; }
    }

    public class RatesResponse
    {
        public double USD { get; set; }
        public double GBP { get; set; }
        public double EUR { get; set; }
        public double CNY { get; set; }
        public double CZK { get; set; }
        public double BTC { get; set; }
        public double ETH { get; set; }
        public double BCH { get; set; }
        public double XRP { get; set; }
        public double USDT { get; set; }
        public double USDD { get; set; }
        public double BNB { get; set; }
        public double DOGE { get; set; }
        public double LINK { get; set; }
        public double CHZ { get; set; }
        public double DOT { get; set; }
    }
}