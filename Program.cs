// See https://aka.ms/new-console-template for more information
using WelcomeApp;

Console.WriteLine("Welcome  to App");
signIn obj = new signIn();
Console.WriteLine(obj.Authenticate("admin", "admin@123"));
