namespace Buberdinner.application.services.authentication;


public class AuthenticationService : IAuthenticationService
{
    public AuthResult Login(string Email, string Password)
    {
        return new AuthResult (Guid.NewGuid(), "firstName" , "LastName" ,"token");
    }

    public AuthResult Register(string firstName, string LastName, string Email, string Password)
    {
        return new AuthResult (Guid.NewGuid(), firstName , LastName ,"token");
    }
}