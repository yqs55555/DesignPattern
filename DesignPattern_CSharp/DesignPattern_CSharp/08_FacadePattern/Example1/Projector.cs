using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FacadePattern.Example1
{
    /// <summary>
    /// 投影仪 
    /// </summary>
    public class Projector : IDevice
    {
        public void On()
        {
            Console.WriteLine(this + " On ");
        }

        public void Off()
        {
            Console.WriteLine(this + " Off ");
        }

        public void WideScreenMode()
        {
            Console.WriteLine(this + " Wide Screen Mode ");
        }
    }
}
