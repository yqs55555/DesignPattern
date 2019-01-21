using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CommandPattern.Example1
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light On");
        }

        public void Off()
        {
            Console.WriteLine("Light Off");
        }
    }
}
