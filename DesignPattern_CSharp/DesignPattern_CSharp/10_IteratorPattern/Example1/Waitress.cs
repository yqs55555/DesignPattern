using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.IteratorPattern.Example1
{
    public class Waitress
    {
        private DinerMenu m_dinerMenu;

        public Waitress(DinerMenu dinerMenu)
        {
            this.m_dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IEnumerator dinnerIterator = m_dinerMenu.GetEnumerator();
            Console.WriteLine("MENU\n----\nLUNCH");
            PrintMenu(dinnerIterator);
        }

        private void PrintMenu(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                MenuItem menuItem = enumerator.Current as MenuItem;
                Console.Write(menuItem.Name + ", ");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);
            }
        }
    }
}
