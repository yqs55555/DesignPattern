using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompositePattern.Example1
{
    public class Waitress
    {
        private MenuComponent m_allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.m_allMenus = allMenus;
        }

        public void PrintMenu()
        {
            m_allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            foreach (MenuComponent menuComponent in m_allMenus)
            {
                MenuItem menuItem = menuComponent as MenuItem;
                if (menuItem.IsVegetarian)
                {
                    menuItem.Print();
                }
            }
        }
    }
}
