using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    class AverageWeather : IWeatherDisplay, IObserver<WeatherStats>
    {
        private List<WeatherStats> _weatherStats;
        private IDisposable _cancellation;

        public AverageWeather()
        {
            _weatherStats = new List<WeatherStats>();
        }

        public virtual void Subscribe(IObservable<WeatherStats> weatherStation)
        {
            _cancellation = weatherStation.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("AverageWeather: Avg-temp: {0:F}, Avg-hum: {1:F}, Avg-press: {2:F}",
                _weatherStats.Select(stats => stats.Temperature).Average(),
                _weatherStats.Select(stats => stats.Humidity).Average(),
                _weatherStats.Select(stats => stats.Pressure).Average());
        }

        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
            _weatherStats.Clear();
        }

        public void OnNext(WeatherStats value)
        {
            _weatherStats.Add(value);
            Display();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("An error occured: {0}", error.Message);
        }

        public void OnCompleted()
        {
            _weatherStats.Clear();
        }
    }
}
