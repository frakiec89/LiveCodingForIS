using ConsoleApp4.Interfaces;
using ConsoleApp4.Model;

namespace ConsoleApp4.Services
{
    internal class AuthorizationService : IAuthorizationService
    {
        public ModelView.User Authorization(string? login, string? password)
        {
            Model.User user = new User() { Name = "ivan"};
            return new ModelView.User { Name = user.Name };
        }

        public bool IsTrylogin(string? login)
        {
            return true;
        }

        public bool IsTryPassword(string? pass)
        {
            return true;
        }
    }
}
