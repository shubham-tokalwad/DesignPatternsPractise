using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.Adapter_Pattern
{
    public interface IPaymentGateway
    {
        void Pay();
    }
}
