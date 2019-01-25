using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.IteratorPattern.Example1
{
    public class DinerMenu : IEnumerable
    {
        private static int MAX_ITEMS = 6;
        private int m_numberOfItems = 0;
        private MenuItem[] m_menuItems;

        public DinerMenu()
        {
            m_menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            if (m_numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                m_menuItems[m_numberOfItems++] = new MenuItem(name, description, isVegetarian, price);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new DinerMenuIterator(m_menuItems);
        }
    }
}
