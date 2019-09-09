using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Abstract;

namespace StrategyPattern.Concrete
{
    public class NoFlyBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine(" I can't fly.");
            Console.WriteLine(" ");
        }
    }
}
