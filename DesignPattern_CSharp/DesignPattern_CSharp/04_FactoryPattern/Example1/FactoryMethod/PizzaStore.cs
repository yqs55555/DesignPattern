using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FactoryPattern.Example1.FactoryMethod
{
    public abstract class PizzaStore
    {
        /// <summary>
        /// 对于所有的PizzaStore，都应该有一个Order的方法，并且内容一致
        /// </summary>
        /// <param name="pizzaType"></param>
        /// <returns></returns>
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = this.CreatPizza(pizzaType);

            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }

            return pizza;
        }

        /// <summary>
        /// 对于不同的PizaaStore，要生产的Pizza类型应该由他自身（子类）决定
        /// </summary>
        /// <param name="pizzaType"></param>
        /// <returns></returns>
        protected abstract Pizza CreatPizza(string pizzaType);
    }
}
