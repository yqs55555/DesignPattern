using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    /// <summary>
    /// 鸭鸣器
    /// </summary>
    public class DuckCall : IQuackable
    {
        private IQuackObservable m_quackSender;

        public DuckCall()
        {
            m_quackSender = new QuackSender(this);
        }

        public void Quack()
        {
            Console.WriteLine("Kwak");
            NotifyObservers();
        }

        public void RegisterObserver(Action<IQuackObservable> notifyEventHandler)
        {
            m_quackSender.RegisterObserver(notifyEventHandler);
        }

        public void RemoveObserver(Action<IQuackObservable> notifyEventHandler)
        {
            m_quackSender.RemoveObserver(notifyEventHandler);
        }

        public void NotifyObservers()
        {
            m_quackSender.NotifyObservers();
        }
    }
}
