using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WeatherMenu
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            AddDay();
        }

        public void AddDay()
        {
            /*DayDirectory.AddDay(new Day());
            DayDirectory.AddDay(new Day());*/
            DaysOfWeek.ItemsSource = DayDirectory.GetDay();

        }

        private void DaysOfWeek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainPanelInfoGrid.DataContext = DaysOfWeek.SelectedItem;
            HeurlyForecastLB.ItemsSource = DayDirectory.GetDay()[DaysOfWeek.SelectedIndex].HourlyForecasts;
            NightTextTB.Visibility = Visibility.Visible;
            WindMsTB.Visibility = Visibility.Visible;
            WindMmTB.Visibility = Visibility.Visible;
            SuppresTB.Visibility = Visibility.Visible;
        }
    }
}
