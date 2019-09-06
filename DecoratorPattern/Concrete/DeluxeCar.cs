using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete
{
    public class DeluxeCar : ICar
    {
        public string GetDescription()
        {
            return "This is a deluxe Car";
        }

        public double GetCost()
        {
            return 60000.50;
        }
    }
}
