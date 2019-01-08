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

        public override string Description
        {
            get { return beverage.Description + ", Soy"; }
        }

        public override double Cost()
        {
            return this.beverage.Cost() + 0.15;
        }
    }
}
