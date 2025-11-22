// See https://aka.ms/new-console-template for more information
using DesignPatternsConsoleApp.Adapter_Pattern;
using DesignPatternsConsoleApp.CQRS_Mediator_Pattern;
using DesignPatternsConsoleApp.Decorator_Pattern;
using DesignPatternsConsoleApp.Dependency_Injection;
using DesignPatternsConsoleApp.FactoryPattern;
using DesignPatternsConsoleApp.Observer_Pub_Sub_Pattern;
using DesignPatternsConsoleApp.Repository_Pattern;
using DesignPatternsConsoleApp.SingletonPattern;
using DesignPatternsConsoleApp.StrategyPattern;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

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


//Adapter Pattern
IPaymentGateway paymentGateway = new PaymentAdapter();
paymentGateway.Pay();

//Decorator Pattern
INotifier notifier = new LoggingNotifierDecorator(new DesignPatternsConsoleApp.Decorator_Pattern.EmailNotifier());
notifier.Send("Hello World");

//Observer Pattern
var stock = new Stock();
stock.Register(new Investor());
stock.Notify();

//Repository Pattern
//var repo = new ProductRepository(context);
//await repo.AddAsync(new Product { Name = "Laptop" });

//Dependency Injection
//var services = new ServiceCollection();
//services.AddSingleton<IMessageService, EmailService>();

//var provider = services.BuildServiceProvider();
//var svc = provider.GetRequiredService<IMessageService>();
//svc.Send("Hello!");


//CQRS + Mediator Pattern
//Can't run here because of it should run in main which runs in web api project
//var services = new ServiceCollection();

//// Register MediatR and scan the current assembly
//services.AddMediatR(typeof(Program));

//var provider = services.BuildServiceProvider();
//var mediator = provider.GetRequiredService<IMediator>();

//var result = await mediator.Send(new CreateUserCommand("Shubham", "abc@gmail.com"));

//Console.WriteLine(result);