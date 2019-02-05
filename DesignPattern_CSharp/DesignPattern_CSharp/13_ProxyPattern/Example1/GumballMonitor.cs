using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern_CSharp.StatePattern.Example1;

namespace DesignPattern_CSharp.ProxyPattern.Example1
{
    /// <summary>
    /// Proxy/Stub, Client
    /// </summary>
    public class GumballMonitor
    {
        private GumballMachine m_machine;

        public GumballMonitor(GumballMachine machine)
        {
            this.m_machine = machine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball Machine: " + m_machine.Location);
            Console.WriteLine("Current inventory: " + m_machine.BallsCount + " gumballs");
            Console.WriteLine("Current state: " + m_machine.CurrentState);
        }
    }
}
