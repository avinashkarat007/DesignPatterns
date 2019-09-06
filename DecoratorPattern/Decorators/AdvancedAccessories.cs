using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorators
{
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Advanced Accessories";
        }

        public override double GetCost()
        {
            return base.GetCost() + 5000;
        }
    }
}
