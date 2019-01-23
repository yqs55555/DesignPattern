using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.FacadePattern.Example1
{
    /// <summary>
    /// 功放，扩音器
    /// </summary>
    public class Amplifier : IDevice
    {
        public void On()
        {
            Console.WriteLine(this + " On ");
        }

        public void Off()
        {
            Console.WriteLine(this + " Off ");
        }

        public void SetCd(CdPlayer cd)
        {
            Console.WriteLine(this + " Set CD " + cd);
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine(this + " Set DVD " + dvd);
        }

        public void SetSurroundSound()
        {
            Console.WriteLine(this + " Set Surround Sound ");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine(this + " Set Volume " + volume);
        }
    }
}
