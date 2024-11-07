namespace DailyOps.Contracts.Authentication;

public record LoginRequest(
    string EmployeeId,
    string Password
);