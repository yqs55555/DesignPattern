using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        Dough CreatDough();
        Sauce CreatSauce();
        Cheese CreatCheese();
        Veggies[] CreatVeggies();
        Pepperoni CreatPepperoni();
        Clams CreatClams();
    }
}
