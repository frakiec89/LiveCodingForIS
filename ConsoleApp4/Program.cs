using ConsoleApp4.Interfaces;
using ConsoleApp4.Services;
using ConsoleApp4.ModelView;

IAuthorizationService _authSevice = new AuthorizationService(); // зависимости
IGenerationPage  _generation = new GenerationPage();     // зависимости

Console.WriteLine("Привет  я  программа для авторизации");

Console.WriteLine("Введите  логин");

string login  = Console.ReadLine();

if (_authSevice.IsTrylogin (login)  == false)
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







