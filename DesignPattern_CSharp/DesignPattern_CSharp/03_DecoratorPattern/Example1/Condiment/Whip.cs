using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    /// <summary>
    /// 奶泡
    /// </summary>
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public new string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 0.10;
        }
    }
}
