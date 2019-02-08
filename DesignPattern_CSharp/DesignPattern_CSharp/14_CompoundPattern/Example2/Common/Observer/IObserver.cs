using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.CompoundPattern.Example2
{
    public interface IObserver
    {
        void Update(IObservable sender);
    }

    public interface IObserver<T>
    {
        void Update(IObservable<T> sender, T args);
    }
}
