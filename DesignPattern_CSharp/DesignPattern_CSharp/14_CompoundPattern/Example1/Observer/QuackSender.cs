using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    /// <summary>
    /// 发送Quack发生的类
    /// </summary>
    public class QuackSender : IQuackObservable
    {
        private Action<IQuackObservable> m_quackNotifyEventHandler;
        private IQuackObservable m_duck;

        public QuackSender(IQuackObservable duck)
        {
            this.m_duck = duck;
        }

        public void RegisterObserver(Action<IQuackObservable> observer)
        {
            m_quackNotifyEventHandler += observer;
        }

        public void RemoveObserver(Action<IQuackObservable> notifyEventHandler)
        {
            if (m_quackNotifyEventHandler != null)
            {
                m_quackNotifyEventHandler -= notifyEventHandler;
            }
        }

        public void NotifyObservers()
        {
            if (m_quackNotifyEventHandler != null)
            {
                m_quackNotifyEventHandler(this);
            }
        }

        public override string ToString()
        {
            return m_duck.ToString();
        }
    }
}
