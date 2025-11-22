using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.StrategyPattern
{
    public interface IPaymentStrategy
    {
        void Pay();
    }

    public class CardPayment : IPaymentStrategy
    {
        public void Pay() => Console.WriteLine("Card");
    }
    public class UpiPayment : IPaymentStrategy
    {
        public void Pay() => Console.WriteLine("UPI");
    }

    public class PaymentContext
    {
        private IPaymentStrategy _strategy;
        public PaymentContext(IPaymentStrategy strategy) => _strategy = strategy;

        public void Execute() => _strategy.Pay();
    }

}
