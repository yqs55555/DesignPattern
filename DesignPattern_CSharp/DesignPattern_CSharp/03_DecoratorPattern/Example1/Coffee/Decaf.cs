using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    /// <summary>
    /// 低咖啡因Coffee
    /// </summary>
    public class Decaf : Beverage
    {
        public Decaf()
        {
            BeverageDescription = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
