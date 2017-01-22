using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    class AverageWeather : IWeatherDisplay, IWeatherObserver
    {
        private IWeatherState _weatherState;

        private List<int> _temperatures;
        private List<int> _humidities;
        private List<int> _pressures;

        public AverageWeather(IWeatherState weatherState)
        {
            _weatherState = weatherState;
            _weatherState.RegisterObserver(this);

            _temperatures = new List<int>();
            _humidities = new List<int>();
            _pressures = new List<int>();
        }

        public void Display()
        {
            Console.WriteLine("AverageWeather: Avg-temp: {0:F}, Avg-hum: {1:F}, Avg-press: {2:F}", 
                _temperatures.Average(), 
                _humidities.Average(), 
                _pressures.Average());
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            _temperatures.Add(temperature);
            _humidities.Add(humidity);
            _pressures.Add(pressure);
            Display();
        }
    }
}
