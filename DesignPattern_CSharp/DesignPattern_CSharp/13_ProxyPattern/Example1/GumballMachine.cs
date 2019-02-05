using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern_CSharp.ProxyPattern.Example1;

namespace DesignPattern_CSharp.StatePattern.Example1
{
    /// <summary>
    /// Skeleton(Server0
    /// </summary>
    public partial class GumballMachine : GumballMachineRemote
    {
        private string m_location;

        public int Count => this.BallsCount;
        public string Location => m_location;
        public IState State => this.CurrentState;

        public GumballMachine(string location, int count) : this(count)
        {
            this.m_location = location;
        }
    }
}
