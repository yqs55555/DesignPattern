using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.SingletonPattern.Example1
{
    public class SingletonType2
    {
        private static readonly object m_singletonLock = new object();
        private static SingletonType2 m_uniqueInstance;

        private SingletonType2() { }

        public static SingletonType2 GetInstance()
        {
            lock (m_singletonLock)
            {
                return m_uniqueInstance ?? (m_uniqueInstance = new SingletonType2());
            }
        }

        public void OutPut()
        {
            Console.WriteLine(this);
        }
    }
}
