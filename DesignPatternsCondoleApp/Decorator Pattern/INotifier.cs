using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.Decorator_Pattern
{
    public interface INotifier
    {
        void Send(string message);
    }
}
