using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Abstract;

namespace StrategyPattern.Entities
{
    public abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }

        public IQuackBehaviour QuackBehaviour { get; set; }

        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehaviour.Quack();
        }

        public void PerformFly()
        {
            FlyBehaviour.Fly();
        }


        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!!!!");
        }
    }
}
