using System.ComponentModel.DataAnnotations;

namespace Client
{
    public class ValidationToken
    {
        [Key]
        public int Id { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
        public string Purpose { get; set; }
    }

    public class TokenPurpose
    {
        public const string PasswordReset = "PasswordReset";
    }
}