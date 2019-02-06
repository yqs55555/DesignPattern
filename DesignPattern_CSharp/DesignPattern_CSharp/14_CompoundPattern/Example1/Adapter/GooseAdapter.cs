using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    public class GooseAdapter : IQuackable
    {
        private IQuackObservable m_quackSender;
        private Goose m_goose;

        public GooseAdapter(Goose goose)
        {
            this.m_goose = goose;
            m_quackSender = new QuackSender(this);
        }

        public void Quack()
        {
            this.m_goose.Honk();
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
