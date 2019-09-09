using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Entities;

namespace StrategyPattern
{
    /*

         The Strategy Pattern defines a family of algorithms,
         encapsulates each one, and makes them interchangeable.
         Strategy lets the algorithm vary independently from
         clients that use it.

     */

    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();

            mallardDuck.PerformQuack();

            mallardDuck.PerformFly();

            Console.ReadLine();
        }
    }
}
