using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.ObserverPattern
{
    public class StatisticsDisplay : IWeatherSystemObserver
    {
        private float m_temperature;
        private float m_humidity;
        private float m_pressure;

        public void Update(float temp, float humidity, float pressure)
        {
            m_temperature = temp;
            m_humidity = humidity;
            m_pressure = pressure;
        }

        public void Display()
        {
            Console.WriteLine("Statistics：" + m_temperature + "," + m_humidity + "," + m_pressure);
        }
    }
}
