using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.SimpleFactory
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            this.PizzaName = "Pepperoni Pizza";
        }
    }
}
