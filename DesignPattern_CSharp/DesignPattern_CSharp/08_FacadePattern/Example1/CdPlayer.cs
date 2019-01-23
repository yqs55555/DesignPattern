using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FacadePattern.Example1
{
    /// <summary>
    /// CD播放器
    /// </summary>
    public class CdPlayer : IDevice
    {
        public void On()
        {
            Console.WriteLine(this + " On ");
        }

        public void Off()
        {
            Console.WriteLine(this + " Off ");
        }
    }
}
