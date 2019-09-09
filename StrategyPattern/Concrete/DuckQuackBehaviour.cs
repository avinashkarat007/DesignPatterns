using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Abstract;

namespace StrategyPattern.Concrete
{
    public class DuckQuackBehaviour : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine(" I can quack!!!!");
            Console.WriteLine(" ");
        }
    }
}
