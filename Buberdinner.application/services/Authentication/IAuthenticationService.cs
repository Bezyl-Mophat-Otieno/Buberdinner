namespace Buberdinner.application.services.authentication;

public interface IAuthenticationService {
    public AuthResult Register (string firstName , string LastName , string Email , string Password);
    public AuthResult Login (string Email , string Password);

}