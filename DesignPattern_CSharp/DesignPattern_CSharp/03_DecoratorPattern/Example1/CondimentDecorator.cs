using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;
    }
}
