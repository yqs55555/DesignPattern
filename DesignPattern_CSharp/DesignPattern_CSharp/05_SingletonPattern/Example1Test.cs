using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.SingletonPattern.Example1
{
    public class Example1Test
    {
        public static void Test()
        {
            SingletonType1.GetInstance().OutPut();
            SingletonType1.GetInstance().OutPut();

            SingletonType2.GetInstance().OutPut();
            SingletonType2.GetInstance().OutPut();

            SingletonType3.GetInstance().OutPut();
            SingletonType3.GetInstance().OutPut();

            SingletonType4.GetInstance().OutPut();
            SingletonType4.GetInstance().OutPut();

        }
    }
}
