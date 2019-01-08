using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    /// <summary>
    /// 浓缩Coffee
    /// </summary>
    public class Espresso : Beverage
    {
        public Espresso()
        {
            BeverageDescription = "Espresso Coffee";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
