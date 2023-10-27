using ConsoleApp4.Data;
using ConsoleApp4.Interfaces;
using ConsoleApp4.Model;

namespace ConsoleApp4.Services
{
    internal class AuthorizationService : IAuthorizationService
    {
        IDataList _data;
        public AuthorizationService (IDataList data)
        {
            _data = data;
        }

        public ModelView.User Authorization(string? login, string? password)
        {
            try
            {
                var us = _data.ListUser.Single(x => x.Login == login && x.Password == password);
                return new ModelView.User { Name = us.Name };
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
