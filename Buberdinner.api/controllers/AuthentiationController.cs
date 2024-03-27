using Buberdinner.application.services.authentication;
using Buberdinner.contracts.authentication;
using Microsoft.AspNetCore.Mvc;

namespace Buberdinner.api.controllers;

[ApiController]
[Route("auth")]
public class AuthController:ControllerBase {

    private readonly IAuthenticationService _authenticationService;

    public AuthController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register ( RegisterRequest request ){

        var authenticationResult = _authenticationService.Register(
            request.firstName,
            request.lastName,
            request.email,
            request.password);
        var response = new AuthenticationResponse (
            authenticationResult.id,
            authenticationResult.firstName,
            authenticationResult.lastName,
            authenticationResult.token);
      return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login ( LoginRequest request ){
     var authenticationResult = _authenticationService.Login(
            request.email,
            request.password);
        var response = new AuthenticationResponse (
            authenticationResult.id,
            authenticationResult.firstName,
            authenticationResult.lastName,
            authenticationResult.token);
      return Ok(response);    }
}
