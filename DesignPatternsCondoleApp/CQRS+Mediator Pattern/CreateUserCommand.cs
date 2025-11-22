using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CQRS = Command Query Responsibility Segregation
//Meaning: Split “write” logic and “read” logic into different models.

//Mediator is usually implemented with MediatR library.

//📌 Why it's used in real APIs
//✔ Cleaner code
//✔ Easier to test
//✔ No bloated service classes
//✔ Better separation of concerns
//✔ Perfect for microservices

namespace DesignPatternsConsoleApp.CQRS_Mediator_Pattern
{
    public record CreateUserCommand(string Name, string Email) : IRequest<string>;
}
