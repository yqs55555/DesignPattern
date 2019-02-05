using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using DesignPattern_CSharp.StatePattern.Example1;

namespace DesignPattern_CSharp.ProxyPattern.Example1
{
    public interface GumballMachineRemote
    {
        int Count { get; } 
        string Location { get; }
        IState State { get; }
    }
}
