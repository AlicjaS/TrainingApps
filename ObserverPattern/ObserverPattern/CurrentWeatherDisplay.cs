using System;

namespace ObserverPattern
{
    class CurrentWeatherDisplay : IWeatherDisplay, IWeatherObserver
    {
        private IWeatherState _weatherState;

        private int _temperature;
        private int _humidity;
        private int _pressure;

        public CurrentWeatherDisplay(IWeatherState weatherState)
        {
            _weatherState = weatherState;
            _weatherState.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("CurrentWeatherDisplay: temp: {0}, hum: {1}, press: {2}", _temperature, _humidity, _pressure);
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }
    }
}
