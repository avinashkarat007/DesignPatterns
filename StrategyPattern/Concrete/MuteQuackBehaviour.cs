using StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Concrete
{
    public class MuteQuackBehaviour: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine(" I can't make any quack.");
            Console.WriteLine(" ");
        }
    }
}
