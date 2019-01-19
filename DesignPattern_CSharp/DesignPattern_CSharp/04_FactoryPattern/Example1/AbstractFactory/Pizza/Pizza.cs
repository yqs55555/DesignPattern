using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.AbstractFactory
{
    public abstract class Pizza
    {
        /// <summary>
        /// 名称
        /// </summary>
        protected string PizzaName;
        /// <summary>
        /// 面团
        /// </summary>
        protected Dough Dough;
        /// <summary>
        /// 酱料
        /// </summary>
        protected Sauce Sauce;

        protected Veggies[] Veggies;
        protected Cheese Cheese;
        protected Pepperoni Pepperoni;
        protected Clams Clam;

        public string Name
        {
            get => this.PizzaName;
            set => this.PizzaName = value;
        }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
