using System.Collections.Generic;
using System;

namespace ObserverPattern
{
    class WeatherStation : IObservable<WeatherStats>
    {
        private List<IObserver<WeatherStats>> _observers;
        private List<WeatherStats> _weatherStats;

        public WeatherStation()
        {
            _observers = new List<IObserver<WeatherStats>>();
            _weatherStats = new List<WeatherStats>();
        }
        
        public void NotifyObservers(WeatherStats weatherUpdate)
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(weatherUpdate);
            }
        }

        public void SetWeather(int temperature, int pressure, int humidity)
        {
            var weatherUpdate = new WeatherStats(temperature, humidity, pressure);
            _weatherStats.Add(weatherUpdate);
            NotifyObservers(weatherUpdate);
        }

        public IDisposable Subscribe(IObserver<WeatherStats> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                foreach (var item in _weatherStats)
                    observer.OnNext(item);
            }
            return new DisplaysRemover<WeatherStats>(_observers, observer);
        }
    }

    class DisplaysRemover<WeatherStats> : IDisposable
    {
        private List<IObserver<WeatherStats>> _observers;
        private IObserver<WeatherStats> _observer;

        internal DisplaysRemover(List<IObserver<WeatherStats>> observers, IObserver<WeatherStats> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}
