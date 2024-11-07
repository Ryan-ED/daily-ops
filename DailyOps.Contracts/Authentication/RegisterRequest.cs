namespace DailyOps.Contracts.Authentication;

public record RegisterRequest(
    string EmployeeId,
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string PhoneNumber
);