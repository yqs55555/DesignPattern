using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.ObserverPattern
{
    public class WeatherStation
    {
        private WeatherData m_weatherData;
        private List<IWeatherSystemObserver> m_observers;

        public WeatherStation()
        {
            m_weatherData = new WeatherData();
            m_observers = new List<IWeatherSystemObserver>();
        }

        public void UpdateData(float temperature, float humidity, float pressure)
        {
            m_weatherData.SetMeasurements(temperature, humidity, pressure);
        }

        public void AddObserver(IWeatherSystemObserver observer)
        {
            m_weatherData.RegisterObserver(observer);
            m_observers.Add(observer);
        }

        public void RemoveObserver(IWeatherSystemObserver observer)
        {
            m_weatherData.RemoveObserver(observer);
            m_observers.Remove(observer);
        }
    }
}
