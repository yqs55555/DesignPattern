using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern_CSharp.CompoundPattern.Example1;

namespace DesignPattern_CSharp.CompoundPattern
{
    public class Test
    {
        public static void Example1()
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            simulator.Simulate(duckFactory);
        }
    }
}
