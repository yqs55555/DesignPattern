using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Security.Policy;
using System.Text;
using System.Threading;
using DesignPattern_CSharp.StatePattern.Example1;

namespace DesignPattern_CSharp.ProxyPattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            string location = "Seattle";
            int count = 0;
            GumballMachine gumballMachine = new GumballMachine(location, count);

            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);
            
            gumballMonitor.Report();
        }
    }
}
