using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Abstract
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing the pizza!");
            Console.WriteLine(" ");
        }

        public void Bake()
        {
            Console.WriteLine("Baking the pizza!");
            Console.WriteLine(" ");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza!");
            Console.WriteLine(" ");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the pizza!");
            Console.WriteLine(" ");
        }
    }
}
