using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
        }
    }
}
