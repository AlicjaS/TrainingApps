using System.Collections.Generic;

namespace ObserverPattern
{
    class WeatherStation : IWeatherState
    {
        private List<IWeatherObserver> _observers;

        private int _temperature;
        private int _humidity;
        private int _pressure;

        public WeatherStation()
        {
            _observers = new List<IWeatherObserver>();
        }

        public void RegisterObserver(IWeatherObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IWeatherObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void WeatherChanged()
        {
            NotifyObservers();
        }

        public void SetWeather(int temperature, int humidity, int pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            WeatherChanged();
        }
    }
}
