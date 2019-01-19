﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatPizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "cheese":
                {
                    return new NYStyleCheesePizza();
                }
            }

            return null;
        }
    }
}
