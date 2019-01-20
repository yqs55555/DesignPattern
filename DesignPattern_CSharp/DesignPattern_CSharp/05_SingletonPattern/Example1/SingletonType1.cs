using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.SingletonPattern.Example1
{
    public class SingletonType1
    {
        private static SingletonType1 m_uniqueInstance;

        private SingletonType1() { }

        public static SingletonType1 GetInstance()
        {
            return m_uniqueInstance ?? (m_uniqueInstance = new SingletonType1());
        }

        public void OutPut()
        {
            Console.WriteLine(this);
        }
    }
}
