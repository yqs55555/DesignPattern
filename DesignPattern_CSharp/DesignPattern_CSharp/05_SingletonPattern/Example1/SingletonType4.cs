using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.SingletonPattern.Example1
{
    public class SingletonType4
    {
        private static SingletonType4 m_uniqueInstance = new SingletonType4();

        private SingletonType4() { }

        public static SingletonType4 GetInstance()
        {
            return m_uniqueInstance;
        }

        public void OutPut()
        {
            Console.WriteLine(this);
        }
    }
}
