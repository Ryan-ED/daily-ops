namespace DailyOps.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Login(string employeeId, string password)
    {
        return new AuthenticationResult(1, "employeeId", "firstname", "lastname", "email", Guid.NewGuid().ToString());
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string phoneNumber, string employeeId,
        string password)
    {
        return new AuthenticationResult(2, "employeeId", "firstname", "lastname", "email", Guid.NewGuid().ToString());
    }
}