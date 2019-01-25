using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.IteratorPattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            DinerMenu dinerMenu = new DinerMenu();

            Waitress waitress = new Waitress(dinerMenu);

            waitress.PrintMenu();
        }
    }
}
