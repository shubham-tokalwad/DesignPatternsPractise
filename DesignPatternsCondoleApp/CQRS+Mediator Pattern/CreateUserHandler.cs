using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.CQRS_Mediator_Pattern
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, string>
    {
        public Task<string> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"User {request.Name} with email {request.Email} created successfully.");
        }
    }
}
