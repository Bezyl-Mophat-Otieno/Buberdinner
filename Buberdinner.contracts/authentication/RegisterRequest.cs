namespace Buberdinner.contracts.authentication;


public record RegisterRequest (
string firstName,
string lastName,
string email,
string password
);