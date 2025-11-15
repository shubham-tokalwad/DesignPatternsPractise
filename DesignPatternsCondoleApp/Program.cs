// See https://aka.ms/new-console-template for more information
using DesignPatternsConsoleApp.FactoryPattern;

Console.WriteLine("Hello, World!");

Console.WriteLine(NotificationFactory.Create("email"));
Console.WriteLine(NotificationFactory.Create("sms"));