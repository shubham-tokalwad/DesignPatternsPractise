using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.Adapter_Pattern
{
    public class PaymentAdapter: IPaymentGateway
    {
        private readonly ThirdPartyPaymentService _thirdPartyPaymentService=new();

        public void Pay()
        {
            // Adapting the method call to match our interface
            _thirdPartyPaymentService.MakePayment();
        }
    }
}
