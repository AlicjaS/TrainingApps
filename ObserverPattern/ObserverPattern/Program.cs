using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainStation = new WeatherStation();
            var currentDisplay = new CurrentWeatherDisplay(mainStation);
            var averageDisplay = new AverageWeather(mainStation);

            mainStation.SetWeather(20, 30, 1010);
            mainStation.SetWeather(24, 40, 1050);
            mainStation.SetWeather(22, 36, 980);
            mainStation.SetWeather(28, 42, 1010);

            Console.ReadLine();
        }
    }

    interface IWeatherState
    {
        void RegisterObserver(IWeatherObserver observer);
        void RemoveObserver(IWeatherObserver observer);
        void NotifyObservers();
    }

    interface IWeatherObserver
    {
        void Update(int temperature, int humidity, int pressure);
    }

    interface IWeatherDisplay
    {
        void Display();
    }
}
