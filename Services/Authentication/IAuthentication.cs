using System.Threading.Tasks;

namespace Client
{
    public interface IAuthenticationService
    {
        Task<AuthResponse> RegisterUser(LoginRequest userForRegistration);
        Task<AuthResponse> Login(LoginRequest userForAuthentication);
        Task<AuthResponse> Login(Login2AuthRequest auth);

        Task Logout();
    }
}