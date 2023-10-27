using ConsoleApp4.Interfaces;
using ConsoleApp4.Model;

namespace ConsoleApp4.Data
{
    internal class DataList : IDataList
    {
        public List<User> ListUser { get; } = new List<User>()
        {
            new User{ Name =  "Иван" , Login = "admin" , Password = "123" },
            new User{ Name =  "Петя" , Login = "Petty" , Password = "321" },
            new User{ Name =  "Саша" , Login = "Lesha" , Password = "1234" }
        };
    }
}