
namespace Client
{
    public class User
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string RefCode { get; set; }
        public string DisplayName { get; set; }
        public string RecoveryPhrase { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool HasCompletedRegistration => !string.IsNullOrEmpty(this.DisplayName);
    }
}