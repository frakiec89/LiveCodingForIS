using ConsoleApp4.Model;

namespace ConsoleApp4.Interfaces
{
    internal interface IAuthorizationService
    {
        ModelView.User  Authorization(string? login, string? password);
        bool IsTrylogin(string? login);
        bool IsTryPassword(string? pass);
    }
}
