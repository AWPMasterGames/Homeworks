using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class DayDirectory
{
    private static ObservableCollection<Day> Days;

    public static ObservableCollection<Day> GetDay()
    {
        if (Days == null)
        {
            Days = new ObservableCollection<Day>();
            Day day = new Day(
                new ObservableCollection<HourlyForecastModel> {
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel(),
                    new HourlyForecastModel()
                }
                );
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
            Days.Add(day);
        }
        return Days;
    }
    public static void AddDay(Day day)
    {
        Days.Add(day);
    }
    public static void RemoveDay(Day day)
    {
        Days.Remove(day);
    }
}

