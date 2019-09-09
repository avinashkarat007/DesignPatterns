using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Concrete;

namespace StrategyPattern.Entities
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.FlyBehaviour = new FlyWithWingsBehaviour();
            this.QuackBehaviour = new DuckQuackBehaviour();
        }


        public override void Display()
        {
            Console.WriteLine("I look like a Mallard Duck!!!!!!");
        }
    }
}
