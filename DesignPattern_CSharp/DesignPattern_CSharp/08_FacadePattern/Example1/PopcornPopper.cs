using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FacadePattern.Example1
{
    /// <summary>
    /// 爆米花机
    /// </summary>
    public class PopcornPopper : IDevice
    {
        public void On()
        {
            Console.WriteLine(this + " On ");
        }

        public void Off()
        {
            Console.WriteLine(this + " Off ");
        }

        public void Pop()
        {
            Console.WriteLine(this + " Pop");
        }
    }
}
