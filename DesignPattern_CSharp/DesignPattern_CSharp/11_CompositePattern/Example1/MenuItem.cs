using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompositePattern.Example1
{
    public class MenuItem : MenuComponent
    {
        private bool m_vegetarian;
        private double m_price;

        public MenuItem(string name, string desc, bool vegetarian, double price)
        {
            this.MenuName = name;
            this.MenuDescription = desc;
            this.m_vegetarian = vegetarian;
            this.m_price = price;
        }

        public bool IsVegetarian => m_vegetarian;

        public override int ChildCount => -1;

        public override double GetPrice()
        {
            return this.m_price;
        }

        public override void Print()
        {
            Console.Write("    " + Name);
            if (IsVegetarian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("        --  " + Description);
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            throw new NotSupportedException();
        }
    }
}
