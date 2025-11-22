using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.Decorator_Pattern
{
    public class LoggingNotifierDecorator : INotifier
    {
        private readonly INotifier _notifier;

        public LoggingNotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public void Send(string message)
        {
            Console.WriteLine("Log: Sending notification...");
            _notifier.Send(message);
        }
    }

}
