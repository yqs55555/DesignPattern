using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatPizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                {
                    return new CheesePizza();
                }
                case "pepperoni":
                {
                    return new PepperoniPizza();
                }
                case "clam":
                {
                    return new ClamPizza();
                }
                case "veggie":
                {
                    return new VeggiePizza();
                }
            }
            return null;
        }
    }
}
