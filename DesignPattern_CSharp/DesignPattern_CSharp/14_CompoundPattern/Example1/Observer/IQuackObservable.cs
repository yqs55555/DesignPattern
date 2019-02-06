using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example1
{
    /// <summary>
    /// Quack可以被观察
    /// </summary>
    public interface IQuackObservable
    {
        void RegisterObserver(Action<IQuackObservable> notifyEventHandler);
        void RemoveObserver(Action<IQuackObservable> notifyEventHandler);
        void NotifyObservers();
    }
}
