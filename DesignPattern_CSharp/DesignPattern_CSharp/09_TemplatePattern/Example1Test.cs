using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.TemplatePattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            Tea tea = new Tea();
            tea.PrepareRecipe();
            Console.WriteLine("----------------------------------------------------");
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();
        }
    }
}
