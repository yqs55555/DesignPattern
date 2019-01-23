using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FacadePattern.Example1
{
    /// <summary>
    /// 剧场灯光
    /// </summary>
    public class TheaterLights : IDevice
    {
        public void On()
        {
            Console.WriteLine(this + " On");
        }

        public void Off()
        {
            Console.WriteLine(this + " Off");
        }

        public void Dim(int dim)
        {
            Console.WriteLine(this + " Dim " + dim);
        }
    }
}
