using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1
{
    public abstract class PizzaStore
    {
        
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = this.CreatPizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatPizza(string pizzaType);
    }
}
