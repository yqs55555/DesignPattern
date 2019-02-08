using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example2
{
    public interface IObservable
    {
        void RegisterObserver(Action<IObservable> notifyEventHandler);
        void RemoveObserver(Action<IObservable> notifyEventHandler);
        void NotifyObservers();
    }

    public interface IObservable<T>
    {
        void RegisterObserver(Action<IObservable<T>, T> notifyEventHandler, T args);
        void RemoveObserver(Action<IObservable<T>, T> notifyEventHandler, T args);
        void NotifyObservers(T args);
    }
}
