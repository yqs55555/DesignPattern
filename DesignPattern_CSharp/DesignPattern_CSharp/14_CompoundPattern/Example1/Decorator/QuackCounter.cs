using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    public class QuackCounter : IQuackable
    {
        private IQuackable m_duck;
        private static int m_numberOfQuacks;
        private IQuackObservable m_quackSender;

        public static int Quacks => m_numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            this.m_duck = duck;
            m_quackSender = new QuackSender(this);
        }

        public void Quack()
        {
            m_duck.Quack();
            m_numberOfQuacks++;
        }

        /// <summary>
        /// 观察QuackCounter实际上是在观察QuackCounter里的m_duck
        /// </summary>
        /// <param name="notifyEventHandler"></param>
        public void RegisterObserver(Action<IQuackObservable> notifyEventHandler)
        {
            m_duck.RegisterObserver(notifyEventHandler);
        }

        public void RemoveObserver(Action<IQuackObservable> notifyEventHandler)
        {
            m_duck.RemoveObserver(notifyEventHandler);
        }

        public void NotifyObservers()
        {
            m_duck.NotifyObservers();
        }
    }
}
