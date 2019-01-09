using System;
using System.Collections.Generic;

namespace DesignPattern_CSharp.DecoratorPattern.Example1
{
    /// <summary>
    /// 豆浆
    /// </summary>
    public class Soy : CondimentDecorator
    {
        private List<double> m_costLevel = new List<double>()
        {
            0.10, 0.15, 0.20
        };
        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
            this.BeverageSize = beverage.Size;
        }

        public override string Description => Beverage.Description + ", Soy";

        public override double Cost()
        {
            if (this.BeverageSize < 0 || this.BeverageSize >= m_costLevel.Count)
            {
                Console.WriteLine("Size Error");
                return this.Beverage.Cost();
            }
            else
            {
                return this.Beverage.Cost() + m_costLevel[this.BeverageSize];
            }
        }
    }
}
