using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsConsoleApp.Observer_Pub_Sub_Pattern
{
    public interface IInvestor
    {
        void Update();
    }

    public class Investor : IInvestor
    {
        public void Update() => Console.WriteLine("Stock price changed!");
    }

}
