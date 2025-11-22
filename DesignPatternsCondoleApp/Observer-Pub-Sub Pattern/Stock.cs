using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used when multiple components need to react to an event.

//📌 Real usage

//✔ Azure Service Bus
//✔ Event Grid
//✔ Kafka / RabbitMQ
//✔ Domain events in clean architecture
//✔ UI frameworks
namespace DesignPatternsConsoleApp.Observer_Pub_Sub_Pattern
{
    //Subject (publisher)
    public class Stock
    {
        private List<IInvestor> _investors = new();

        public void Register(IInvestor investor) => _investors.Add(investor);

        public void Notify()
        {
            foreach (var investor in _investors)
                investor.Update();
        }
    }

}
