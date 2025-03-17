using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

class HourlyForecastModel
{
    private Random rand = new Random();
    public DateTime Time { get; set; }

    public float Temperature { get; set; }
    public float ApparentTemperature { get; set; }
    public float RelativeHumidity { get; set; }
    public float SurfasePressure { get; set; }
    public float WindSpeed { get; set; }
    public WindDirection Direction { get; set; }
    public WeatherCodes Weather {  get; set; }

    public HourlyForecastModel( float temperature = 5.1f, float apparentTemperature = 5.2f, float relationHumidity = 5.3f, float surfasePressure = 5.4f, float windSpeed = 5.5f, WindDirection windDirection = WindDirection.West, WeatherCodes weatherCodes = WeatherCodes.ClearSky) 
    { 
        Time = DateTime.Now.AddDays(rand.Next(5,30));
        Temperature = temperature;
        ApparentTemperature = apparentTemperature;
        RelativeHumidity = relationHumidity;
        SurfasePressure = surfasePressure;
        WindSpeed = windSpeed;
        Direction = windDirection;
        Weather = weatherCodes;
    }
}

