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
            Waitress waitress = new Waitress(new DinerMenu());
            waitress.PrintMenu();
            Console.WriteLine("--------------------------------------------------------------------------");

            waitress = new Waitress(new DinerMenuYield());
            waitress.PrintMenu();
        }
    }
}
