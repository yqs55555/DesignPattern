using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.AbstractFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreatDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreatSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese CreatCheese()
        {
            return new ReggianoCheese();
        }

        public Veggies[] CreatVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

        public Pepperoni CreatPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams CreatClams()
        {
            return new FreshClams();
        }
    }
}
