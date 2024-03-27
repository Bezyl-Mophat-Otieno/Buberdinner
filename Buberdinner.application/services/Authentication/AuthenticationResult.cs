namespace Buberdinner.application.services.authentication;
public record AuthResult (
    Guid id ,
    string firstName,
    string lastName,
    string token
);