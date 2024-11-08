namespace DailyOps.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(string employeeId, string password);
    AuthenticationResult Register(string firstName, string lastName, string email, string phoneNumber, string employeeId, string password);
}