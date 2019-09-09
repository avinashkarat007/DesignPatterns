using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Abstract;
using FactoryPattern.Factory;

namespace FactoryPattern.Store
{
    public class SimplePizzaStore
    {
        private readonly SimplePizzaFactory _pizzaFactory;

        public SimplePizzaStore(SimplePizzaFactory simplePizzaFactory)
        {
            this._pizzaFactory = simplePizzaFactory;
        }

        public Pizza OrderPizza(string type)
        {
            var pizza = this._pizzaFactory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
