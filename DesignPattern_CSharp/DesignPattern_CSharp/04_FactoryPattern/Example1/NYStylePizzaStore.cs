using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatPizza(string pizzaType)
        {
            throw new NotImplementedException();
        }
    }
}
