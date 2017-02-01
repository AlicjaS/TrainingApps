namespace ObserverPattern
{
    class WeatherStats
    {
        public int Temperature { get; private set; }
        public int Pressure { get; private set; }
        public int Humidity { get; private set; }

        public WeatherStats(int temperature, int pressure, int humidity)
        {
            Temperature = temperature;
            Pressure = pressure;
            Humidity = humidity;
        }
    }
}
