using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Day
{
    public DateTime Date { get; set; }
    public string WeekDay { get; set; }
    public string Location { get; set; }
    public float MaxTemperature { get; set; }
    public float MinTemperature { get; set; }
    public WeatherCodes WeatherCodes { get; set; }
    public float SurfasePressure { get; set; }
    public float WindSpeed { get; set; }
    public float WindSpeed2 { get; set; }
    public WindDirection Direction { get; set; }
    public ObservableCollection<HourlyForecastModel> HourlyForecasts { get; set; }

    public Day(ObservableCollection<HourlyForecastModel> hourlyforecasts, string weekDay = "Sunday", string location="Москва", WeatherCodes weatherCodes = WeatherCodes.Windy , float maxTemp = 17, float MinTempe = -22 , float windSpeed = 5, float windSpeed2 = 759, WindDirection windDirection = WindDirection.Sud, float suprafecepressure = 5)
    {
        WeekDay = weekDay;
        Location = location;
        MaxTemperature = maxTemp;
        MinTemperature = MinTempe;
        WindSpeed = windSpeed;
        WindSpeed2 = windSpeed2;
        WeatherCodes = weatherCodes;
        Direction = windDirection;
        SurfasePressure = suprafecepressure;
        HourlyForecasts = hourlyforecasts;
    }

    public void OpenDayInfo()
    {
        
    }
}

