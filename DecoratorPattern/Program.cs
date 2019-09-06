using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Abstract;
using DecoratorPattern.Concrete;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        /*
         
        Ref : https://www.c-sharpcorner.com/UploadFile/damubetha/decorator-pattern-in-csharp/

        Definition : The Decorator Pattern provides a flexible alternative to sub classing for extending functionality dynamically.
         */
        static void Main(string[] args)
        {
            ICar economyCar = new EconomyCar();

            // Wrapping an economy car with basic accessories.
            CarAccessoriesDecorator objAccessoriesDecorator = new BasicAccessories(economyCar);

            // Wrapping the economy car with sports accessories also.
            objAccessoriesDecorator = new SportsAccessories(objAccessoriesDecorator);

            // Wrapping the economy car with luxury accessories.
            objAccessoriesDecorator = new AdvancedAccessories(objAccessoriesDecorator);

            Console.WriteLine(" Car details : " + objAccessoriesDecorator.GetDescription());
            Console.WriteLine(" ");
            Console.WriteLine("Total Price : " + objAccessoriesDecorator.GetCost());
            Console.ReadLine();
        }
    }
}
