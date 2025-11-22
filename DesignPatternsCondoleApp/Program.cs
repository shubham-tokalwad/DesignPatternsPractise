// See https://aka.ms/new-console-template for more information
using DesignPatternsConsoleApp.CQRS_Mediator_Pattern;
using DesignPatternsConsoleApp.FactoryPattern;
using DesignPatternsConsoleApp.SingletonPattern;
using DesignPatternsConsoleApp.StrategyPattern;
using MediatR;

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

//CQRS + Mediator Pattern
//Can't run here because of it should run in main which runs in web api project
//var services = new ServiceCollection();

//// Register MediatR and scan the current assembly
//services.AddMediatR(typeof(Program));

//var provider = services.BuildServiceProvider();
//var mediator = provider.GetRequiredService<IMediator>();

//var result = await mediator.Send(new CreateUserCommand("Shubham", "abc@gmail.com"));

//Console.WriteLine(result);