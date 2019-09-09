using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Abstract;
using FactoryPattern.Entities;

namespace FactoryPattern.Factory
{
    public class SimplePizzaFactory
    {
        private static readonly Dictionary<string, Pizza> PizzaTypeCollection;

        static SimplePizzaFactory()
        {
            PizzaTypeCollection = new Dictionary<string, Pizza>();

            PizzaTypeCollection.Add("Cheese", new CheesePizza());
            PizzaTypeCollection.Add("Clam", new ClamPizza());
            PizzaTypeCollection.Add("Pepperoni", new PepperoniPizza());
            PizzaTypeCollection.Add("Veggie", new VeggiePizza());
        }

        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = PizzaTypeCollection[pizzaType];
            return pizza;
        }
    }
}
