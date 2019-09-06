using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Abstract;

namespace DecoratorPattern.Concrete
{
    public class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "This is an Economy Car";
        }

        public double GetCost()
        {
            return 45000.50;
        }
    }
}
