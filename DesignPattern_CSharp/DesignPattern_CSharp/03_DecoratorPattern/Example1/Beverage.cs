﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.DecoratorPattern
{
    public abstract class Beverage
    {
        protected string BeverageDescription = "Unknown Beverage";
        protected int BeverageSize = 1;

        public virtual string Description => this.BeverageSize + " Size " + this.BeverageDescription;

        /// <summary>
        /// 0小杯、1中杯、2大杯
        /// </summary>
        public virtual int Size
        {
            get => this.BeverageSize;
            set => this.BeverageSize = value;
        }

        public abstract double Cost();
    }
}
