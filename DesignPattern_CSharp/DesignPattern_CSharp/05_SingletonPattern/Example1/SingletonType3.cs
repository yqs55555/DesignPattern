using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.SingletonPattern.Example1
{
    public class SingletonType3
    {
        private static readonly object m_singletonLock = new object();
        private static volatile SingletonType3 m_uniqueInstance;

        private SingletonType3() { }

        public static SingletonType3 GetInstance()
        {
            if (m_uniqueInstance == null)
            {
                lock (m_singletonLock)
                {
                    if (m_uniqueInstance == null)
                    {
                        m_uniqueInstance = new SingletonType3();
                    }
                }
            }

            return m_uniqueInstance;
        }

        public void OutPut()
        {
            Console.WriteLine(this);
        }
    }
}
