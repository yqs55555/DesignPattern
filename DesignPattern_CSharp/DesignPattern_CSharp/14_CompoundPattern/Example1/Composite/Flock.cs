using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    /// <summary>
    /// 群
    /// </summary>
    public class Flock : IQuackable
    {
        private List<IQuackable> m_quackers = new List<IQuackable>();
        private IQuackObservable m_quackSender;

        public Flock()
        {
            m_quackSender = new QuackSender(this);
        }

        public void Add(params IQuackable[] quackers)
        {
            foreach (IQuackable quacker in quackers)
            {
                Add(quacker);
            }
        }

        public void Add(IQuackable quacker)
        {
            m_quackers.Add(quacker);
        }
        
        public void Quack()
        {
            foreach (IQuackable quacker in m_quackers)
            {
                quacker.Quack();
            }
        }

        /// <summary>
        /// 观察群实际上是在观察这个群里的所有duck
        /// </summary>
        /// <param name="notifyEventHandler"></param>
        public void RegisterObserver(Action<IQuackObservable> notifyEventHandler)
        {
            foreach (IQuackable quacker in m_quackers)
            {
                quacker.RegisterObserver(notifyEventHandler);
            }
        }

        public void RemoveObserver(Action<IQuackObservable> notifyEventHandler)
        {
            foreach (IQuackable quacker in m_quackers)
            {
                quacker.RemoveObserver(notifyEventHandler);
            }
        }

        public void NotifyObservers()
        {
            foreach (IQuackable quacker in m_quackers)
            {
                quacker.NotifyObservers();
            }
        }
    }
}
