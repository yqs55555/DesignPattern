using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    /// <summary>
    /// 深焙Coffee
    /// </summary>
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.BeverageDescription = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
