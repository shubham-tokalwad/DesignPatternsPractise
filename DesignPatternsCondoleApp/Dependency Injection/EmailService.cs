using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.Dependency_Injection
{
    public class EmailService : IMessageService
    {
        public void Send(string message) => Console.WriteLine("Email: " + message);
    }
}
