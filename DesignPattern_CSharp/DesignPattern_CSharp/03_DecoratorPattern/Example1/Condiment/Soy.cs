using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    /// <summary>
    /// 豆浆
    /// </summary>
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public new string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 0.15;
        }
    }
}
