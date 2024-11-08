using DailyOps.Application.Services.Authentication;
using DailyOps.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace DailyOps.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController(IAuthenticationService authenticationService) : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = authenticationService.Register(request.FirstName, request.LastName, request.Email, request.PhoneNumber, request.EmployeeId, request.Password);
        
        var authenticationResponse = new AuthenticationResponse
        (
            authResult.Id,
            authResult.EmployeeId,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
        );
        
        return Ok(authenticationResponse);
    }
    
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = authenticationService.Login(request.EmployeeId, request.Password);
        
        var authenticationResponse = new AuthenticationResponse
        (
            authResult.Id,
            authResult.EmployeeId,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
        );
        
        return Ok(authenticationResponse);
    }
}