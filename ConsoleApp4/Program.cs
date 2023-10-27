using ConsoleApp4.Interfaces;
using ConsoleApp4.Services;
using ConsoleApp4.ModelView;
using ConsoleApp4.Data;

IDataList _data =   new DataList();// зависимости
IAuthorizationService _authSevice = new AuthorizationService(_data); // зависимости
IGenerationPage  _generation = new GenerationPage();     // зависимости


while (true)
{
     Console.Clear();
     Start(_authSevice, _generation);
}

static void  Start(IAuthorizationService _authSevice, IGenerationPage _generation)
{
    Console.WriteLine("Привет  я  программа для авторизации");

    Console.WriteLine("Введите  логин");

    string login = Console.ReadLine();

    if (_authSevice.IsTrylogin(login) == false)
    {
        Console.WriteLine("Плохой логин");
        return;
    }
    Console.WriteLine("Введите  пароль");

    string password = Console.ReadLine();

    if (_authSevice.IsTryPassword(password) == false)
    {
        Console.WriteLine("Плохой пароль");
        return;
    }
    try
    {
        ConsoleApp4.ModelView.User user = _authSevice.Authorization(login, password);
        Console.WriteLine($"Привет {user.Name}");
        _generation.RunMenu(user.Name);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally { Console.ReadLine(); }
}