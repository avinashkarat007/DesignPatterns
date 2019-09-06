using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Abstract;

namespace DecoratorPattern.Decorators
{
    public abstract class CarAccessoriesDecorator : ICar
    {
        private ICar _car;

        public CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }
    }
}
