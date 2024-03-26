namespace Buberdinner.contracts.authentication;


public record LoginRequest (
string email,
string password
);