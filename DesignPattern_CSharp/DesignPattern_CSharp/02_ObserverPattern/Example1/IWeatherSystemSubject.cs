using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.ObserverPattern
{
    public interface IWeatherSystemSubject
    {
        void RegisterObserver(IWeatherSystemObserver observer);
        void RemoveObserver(IWeatherSystemObserver observer);
        void NotifyObservers();
    }
}
