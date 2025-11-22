// See https://aka.ms/new-console-template for more information
using DesignPatternsConsoleApp.FactoryPattern;
using DesignPatternsConsoleApp.SingletonPattern;
using DesignPatternsConsoleApp.StrategyPattern;

Console.WriteLine("Hello, World!");

//Factory Pattern
//Console.WriteLine(NotificationFactory.Create("email"));
//Console.WriteLine(NotificationFactory.Create("sms"));

//Strategy Pattern
//Card
IPaymentStrategy paymentStrategy = new CardPayment();
PaymentContext context = new PaymentContext(paymentStrategy);
context.Execute();

//UPI
context = new PaymentContext(new UpiPayment());
context.Execute();

//Singleton Pattern
var logger1 = Logger.Instance;