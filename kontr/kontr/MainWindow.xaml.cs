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
using System.IO;
using kontr.Classes;
using kontr.windowes;

namespace kontr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user = new User();
        Window[][] windows = new Window[2][];
        public MainWindow()
        {
            InitializeComponent();
            windows[0] = new Window[3];
            windows[1] = new Window[3];
            windows[0][0] = new Step1_1(user);
            windows[0][1] = new Step2_1(user);
            windows[0][2] = new Step3_1(user);
            windows[1][0] = new Step3_2(user);
            windows[1][1] = new Step3_2(user);
            windows[1][2] = new Step3_2(user);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Step1_1 step = new Step1_1(user);
            step.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Step1_2 step = new Step1_2(user);
            step.Show();
            this.Close();
        }

        private void LoadSave(object sender, RoutedEventArgs e)
        {
            int index1, index2;
            string[] temp = File.ReadAllLines("autosave.txt");
            try
            {
                user.Photo = temp[0];
                user.Name = temp[1];
                user.Email = temp[2];
                user.Phone = temp[3];
                user.DateOfBirth = temp[4];
                user.Specialization = temp[5];
                user.Faculty = temp[6];
                user.Post = temp[7];
                user.WorkTime = temp[8];
                user.Duties = temp[9];
                index1 = int.Parse(temp[10]);
                index2 = int.Parse(temp[11]);
                windows[index1][index2].Show();
                this.Close();
            }
            catch (Exception e)
            {
                return;
            }
        }
    }
}
