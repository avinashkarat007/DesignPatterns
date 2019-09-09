using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Abstract;

namespace StrategyPattern.Concrete
{
    public class SqueackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("I can make squeack sound only!!!");
            Console.WriteLine(" ");
        }
    }
}
