namespace DailyOps.Contracts.Authentication;

public record AuthenticationResponse(
    int Id,
    string EmployeeId,
    string FirstName,
    string LastName,
    string Email,
    string Token
);