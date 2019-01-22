using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DesignPattern_CSharp.AdapterPattern.Example1
{
    public class TurkeyObjectAdapter : IDuck
    {
        private ITurkey m_turkey;

        public TurkeyObjectAdapter(ITurkey turkey)
        {
            this.m_turkey = turkey;
        }

        public void Quack()
        {
            m_turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                m_turkey.Fly();
            }
        }
    }
}
