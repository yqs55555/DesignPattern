using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.IteratorPattern.Example1
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsVegetarian { get; private set; }
        public double Price { get; private set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            this.Name = name;
            this.Description = description;
            this.IsVegetarian = isVegetarian;
            this.Price = price;
        }
    }
}
