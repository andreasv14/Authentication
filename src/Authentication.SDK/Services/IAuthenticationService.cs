using Authentication.SDK.Models;

namespace Authentication.SDK.Services;

public interface IAuthenticationService
{
    AuthenticationResult Login(string firstName, string lastName, string email, string password);

    AuthenticationResult Register(string firstName, string lastName, string email, string password);
}