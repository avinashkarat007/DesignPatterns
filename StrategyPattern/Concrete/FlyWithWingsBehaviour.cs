using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Abstract;

namespace StrategyPattern.Concrete
{
    class FlyWithWingsBehaviour : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine(" I can fly with wings!!!!!");
            Console.WriteLine(" ");
        }
    }
}
