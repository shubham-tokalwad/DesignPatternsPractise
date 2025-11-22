using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used when your code needs to talk to a third-party API or service whose API doesn’t match your internal design.

//📌 Real examples
//Converting your app’s model → Stripe/Azure/PayPal model
//Wrapping Azure Service Bus client in your own interface
//Normalizing different SMS gateway providers

namespace DesignPatternsConsoleApp.Adapter_Pattern
{
    public class ThirdPartyPaymentService
    {
        public void MakePayment() => Console.WriteLine("3rd party payment done");
    }
}
