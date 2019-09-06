using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorators
{
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Sports Accessories";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10000.68;
        }
    }
}
