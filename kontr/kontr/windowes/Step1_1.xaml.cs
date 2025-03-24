using kontr.Classes;
using Microsoft.Win32;
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
using kontr.windowes;

namespace kontr.windowes
{
    /// <summary>
    /// Логика взаимодействия для Step1_1.xaml
    /// </summary>
    public partial class Step1_1 : Window
    {
        User user = new User();
        public Step1_1(User user)
        {
            InitializeComponent();
            this.user = user;
            MainGrid.DataContext = user;
            UserPhoto.Source = LoadImageSource(user.Photo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string filename;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|All files (*.*)|*.*",
                Title = "Выберите фотографию"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                filename = System.IO.Path.GetDirectoryName(openFileDialog.FileName);

                try
                {
                    user.Photo = openFileDialog.FileName;
                    UserPhoto.Source = GetImageSource(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private ImageSource GetImageSource(string path)
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
                MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return bitmap;

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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Step2_1 step = new Step2_1(user);
            step.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.Create("autosave.txt").Dispose();

                
            File.WriteAllText("autosave.txt", $"{user.ToSave()}\n0\n0");
        }
    }
}
