using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.SimpleFactory
{
    public class PizzaStore
    {
        private SimplePizzaFactory m_factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.m_factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = m_factory.CreatPizza(type);

            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }

            return pizza;
        }
    }
}
