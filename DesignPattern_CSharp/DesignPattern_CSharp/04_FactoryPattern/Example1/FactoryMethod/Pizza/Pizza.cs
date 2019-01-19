using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.FactoryMethod
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
        protected string Dough;
        /// <summary>
        /// 酱料
        /// </summary>
        protected string Sauce;

        protected List<string> Toppings = new List<string>();

        public string Name => this.PizzaName;

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing " + PizzaName);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            foreach (string topping in Toppings)
            {
                Console.WriteLine("    " + topping);
            }
        }

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
