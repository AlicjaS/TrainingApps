using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainStation = new WeatherStation();
            var currentDisplay = new CurrentWeatherDisplay();
            var averageDisplay = new AverageWeather();

            mainStation.Subscribe(currentDisplay);
            mainStation.Subscribe(averageDisplay);
            
            mainStation.SetWeather(20, 30, 1010);
            mainStation.SetWeather(24, 40, 1050);
            mainStation.SetWeather(22, 36, 980);
            mainStation.SetWeather(28, 42, 1010);

            Console.ReadLine();
        }
    }

    interface IWeatherDisplay
    {
        void Display();
    }
}
