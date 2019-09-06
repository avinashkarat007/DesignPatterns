using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorators
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Basic Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 1200;
        }
    }
}
