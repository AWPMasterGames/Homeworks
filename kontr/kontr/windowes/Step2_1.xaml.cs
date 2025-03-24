using kontr.Classes;
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
using System.Windows.Shapes;
using System.IO;

namespace kontr.windowes
{
    /// <summary>
    /// Логика взаимодействия для Step2_1.xaml
    /// </summary>
    public partial class Step2_1 : Window
    {
        User user = new User();
        public Step2_1(User user)
        {
            InitializeComponent();
            this.user = user;
            MainGrid.DataContext = this.user;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Step1_1 step = new Step1_1(user);
            step.Show();
            this.Close();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Step3_1 step = new Step3_1(user);
            step.Show();
            this.Close();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.Create("autosave.txt").Dispose();


            File.WriteAllText("autosave.txt", $"{user.ToSave()}\n0\n1");
        }
    }
}
