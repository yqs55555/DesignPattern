﻿namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    /// <summary>
    /// 奶泡
    /// </summary>
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
            this.BeverageSize = beverage.Size;
        }

        public override string Description => Beverage.Description + ", Whip";

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.10;
        }
    }
}
