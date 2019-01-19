﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.AbstractFactory
{
    public class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory m_ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.m_ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            this.Dough = m_ingredientFactory.CreatDough();
            this.Sauce = m_ingredientFactory.CreatSauce();
            this.Cheese = m_ingredientFactory.CreatCheese();
            this.Clam = m_ingredientFactory.CreatClams();
        }
    }
}
