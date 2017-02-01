using System;
using System.Collections.Generic;
using System.Linq;

namespace ObserverPattern
{
    class CurrentWeatherDisplay : IWeatherDisplay, IObserver<WeatherStats>
    {
        private List<WeatherStats> _weatherStats;
        private IDisposable _cancellation;

        public CurrentWeatherDisplay()
        {
            _weatherStats = new List<WeatherStats>();
        }

        public virtual void Subscribe(IObservable<WeatherStats> weatherStation)
        {
            _cancellation = weatherStation.Subscribe(this);
        }

        public void Display()
        {
            Console.WriteLine("CurrentWeatherDisplay: temp: {0}, hum: {1}, press: {2}", 
                _weatherStats.Last().Temperature, 
                _weatherStats.Last().Humidity, 
                _weatherStats.Last().Pressure);
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
