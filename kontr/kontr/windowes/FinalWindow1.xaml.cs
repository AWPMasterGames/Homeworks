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
using kontr.windowes;
using kontr.Classes;
using Microsoft.Win32;
using System.IO;
namespace kontr.windowes
{
    /// <summary>
    /// Логика взаимодействия для FinalWindow1.xaml
    /// </summary>
    public partial class FinalWindow1 : Window
    {
        User user = new User();
        public FinalWindow1(User user)
        {
            InitializeComponent();
            this.user = user;
            UserPhoto.Source = LoadImageSource(user.Photo);
            MainGrid.DataContext = this.user;
        }
        private ImageSource LoadImageSource(string path)
        {
            BitmapImage bitmap = new BitmapImage();
            try
            {
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(path);
                bitmap.EndInit();
            }
            catch (Exception ex)
            {

            }
            return bitmap;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "pdf files (*.pdf)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == true)
            {
                // Code to write the stream goes here.
                File.WriteAllText(saveFileDialog1.FileName, user.ToSave());

            }
        }
    }
}
