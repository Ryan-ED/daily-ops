namespace DailyOps.Application.Services.Authentication;

public record AuthenticationResult(
    int Id,
    string EmployeeId,
    string FirstName,
    string LastName,
    string Email,
    string Token
);