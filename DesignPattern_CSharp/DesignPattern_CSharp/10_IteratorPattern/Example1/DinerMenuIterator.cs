using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.IteratorPattern.Example1
{
    public class DinerMenuIterator : IEnumerator
    {
        private MenuItem[] m_items;
        private int m_position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.m_items = items;
        }

        public bool MoveNext()
        {
            m_position++;
            return m_position < m_items.Length && m_items[m_position] != null;
        }

        public void Reset()
        {
            m_position = -1;
        }

        public Object Current => m_items[m_position];
    }
}
