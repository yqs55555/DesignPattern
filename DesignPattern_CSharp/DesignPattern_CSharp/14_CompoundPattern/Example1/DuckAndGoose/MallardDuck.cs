using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    /// <summary>
    /// 绿头鸭
    /// </summary>
    public class MallardDuck : IQuackable
    {
        private IQuackObservable m_quackSender;

        public MallardDuck()
        {
            m_quackSender = new QuackSender(this);
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
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
