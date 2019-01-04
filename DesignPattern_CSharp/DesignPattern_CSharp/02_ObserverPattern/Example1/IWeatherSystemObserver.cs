using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.ObserverPattern
{
    public interface IWeatherSystemObserver : IDisplayElement
    {
        void Update(float temp, float humidity, float pressure);
    }
}
