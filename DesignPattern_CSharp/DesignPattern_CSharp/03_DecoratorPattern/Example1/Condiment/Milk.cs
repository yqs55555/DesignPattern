using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public new string GetDescription()
        {
            return beverage.GetDescription() + ", Milk"; 
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 0.10;
        }
    }
}
