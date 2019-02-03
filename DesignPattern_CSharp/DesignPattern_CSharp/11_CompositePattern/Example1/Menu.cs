using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompositePattern.Example1
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> m_menuComponents;

        public Menu(string name, string desc)
        {
            this.MenuName = name;
            this.MenuDescription = desc;
            m_menuComponents = new List<MenuComponent>();
        }

        public override double GetPrice()
        {
            throw new NotSupportedException();
        }

        public override int ChildCount => m_menuComponents.Count;

        public override void Add(MenuComponent component)
        {
            m_menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            m_menuComponents.Remove(component);
        }

        public override MenuComponent GetChild(int index)
        {
            if (index >= 0 && index < ChildCount)
            {
                return m_menuComponents[index];
            }

            return null;
        }

        public override void Print()
        {
            Console.Write("\n" + Name);
            Console.WriteLine(",  " + Description);
            Console.WriteLine("-------------------------------");

            foreach (MenuComponent component in m_menuComponents)
            {
                component.Print();
            }
        }

        /// <summary>
        /// 这个迭代器返回的是所有的MenuItem叶节点
        /// </summary>
        /// <returns></returns>
        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            foreach (MenuComponent component in m_menuComponents)
            {
                if (component.ChildCount >= 0)  
                {
                    foreach (MenuComponent menuComponent in component)  //进入递归
                    {
                        yield return menuComponent;
                    }
                }
                else
                {
                    yield return component;
                }
            }
        }
    }
}
