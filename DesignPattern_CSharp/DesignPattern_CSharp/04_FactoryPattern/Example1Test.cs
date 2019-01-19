using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            SimpleFactory.PizzaStore sfPizzaStore = new SimpleFactory.PizzaStore(new SimpleFactory.SimplePizzaFactory());
            sfPizzaStore.OrderPizza("clam");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            FactoryMethod.NYPizzaStore fmNyPizzaStore = new FactoryMethod.NYPizzaStore();
            fmNyPizzaStore.OrderPizza("cheese");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            FactoryMethod.ChicagoPizzaStore fmChicagoPizzaStore = new FactoryMethod.ChicagoPizzaStore();
            fmChicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine("---------------------------------------------------------------------------------------");

            AbstractFactory.NYPizzaStore afNyPizzaStore = new AbstractFactory.NYPizzaStore();
            afNyPizzaStore.OrderPizza("cheese");
            Console.WriteLine("---------------------------------------------------------------------------------------");

        }
    }
}
