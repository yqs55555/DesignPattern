﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.SimpleFactory
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            this.PizzaName = "Veggie Pizza";
        }
    }
}
