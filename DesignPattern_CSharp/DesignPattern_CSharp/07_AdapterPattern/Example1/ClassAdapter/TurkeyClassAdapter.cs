using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.AdapterPattern.Example1
{
    public class TurkeyClassAdapter : IDuck, ITurkey
    {
        public void Quack()
        {
            Gobble();
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        void ITurkey.Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I'm flying a short distance");
            }
        }

        void IDuck.Fly()
        {
            (this as ITurkey).Fly();
        }
    }
}
