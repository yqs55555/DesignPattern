using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.ObserverPattern
{
    public class WeatherData : IWeatherSystemSubject
    {
        private List<IWeatherSystemObserver> m_observers;
        private float m_temperature;
        private float m_humidity;
        private float m_pressure;

        public WeatherData()
        {
            m_observers = new List<IWeatherSystemObserver>();
        }

        public void RegisterObserver(IWeatherSystemObserver observer)
        {
            m_observers.Add(observer);
        }

        public void RemoveObserver(IWeatherSystemObserver observer)
        {
            m_observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IWeatherSystemObserver observer in m_observers)
            {
                observer.Update(this.m_temperature, this.m_humidity, this.m_pressure);
            }
        }
    }
}
