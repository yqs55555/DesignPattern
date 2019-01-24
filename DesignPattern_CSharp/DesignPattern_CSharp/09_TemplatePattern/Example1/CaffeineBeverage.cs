using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.TemplatePattern.Example1
{
    public abstract class CaffeineBeverage : Beverage
    {
        public sealed override void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected virtual void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
