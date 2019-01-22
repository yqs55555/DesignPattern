using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.AdapterPattern.Example1
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }
    }
}
