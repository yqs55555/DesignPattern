using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string Description
        {
            get { return this.description; }
        }

        public abstract double Cost();
    }
}
