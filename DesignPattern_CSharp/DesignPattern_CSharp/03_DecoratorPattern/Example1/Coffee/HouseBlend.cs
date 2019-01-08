using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    /// <summary>
    /// 综合Coffee
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.BeverageDescription = "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
