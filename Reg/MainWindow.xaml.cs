using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Reg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        char[] symbols = "!\"#$%&'()*+,-./:;<=>?@[ \\ ]^_`{|}".ToCharArray();
        List<User> Users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ConfirmBtn(object sender, RoutedEventArgs e)
        {
            if (CheckData()) Users.Add(new User(Username.Text, Email.Text, CPassword.Password, Birthday.Text));
        }
        private bool CheckData()
        {
            if (Username.Text.Length < 3)
            {
                UsernameInfo.Text = "Username: Имя пользователя должно быть не менее 3 символа";
                return false;
            }
            UsernameInfo.Text = "Username";
            if (IsUserExist())
            {
                UsernameInfo.Text = "Username: Пользователь уже существует";
            }
            if (Password.Password.Length < 6)
            {
                PasswordInfo.Text = "Password: Пароль должен быть длинее 5 символов";
                return false;
            }

            if (!FindSymbols())
            {
                PasswordInfo.Text = "Password: Пароль должен содержвать в себе символы $#!@._-...";
                return false;
            }

            if (!FindDigits())
            {
                PasswordInfo.Text = "Password: Пароль должен содержвать в себе цифры";

                return false;
            }
            PasswordInfo.Text = "Password";

            if (CPassword.Password != Password.Password)
            {
                CPasswordInfo.Text = "Confirm password: Пароли должны быть одинаковыми";
                return false;
            }
            CPasswordInfo.Text = "Confirm password";

            if (Birthday.Text.Length < 10)
            {
                DateInfoInfo.Text = "Birth date: выберите дату в календоре";
                return false;
            }
            DateInfoInfo.Text = "Birth date";
            return true;
        }
        private bool FindSymbols()
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if (Password.Password.IndexOf(symbols[i]) > -1) return true;
            }
            return false;
        }
        private bool FindDigits()
        {
            int count = 0;
            for (int i = 0; i < Password.Password.Length; i++)
            {
                if (char.IsDigit(Password.Password[i])) { count++; }
            }
            if (count > 0) return true;
            return false;
        }

        private void Password_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Password.Password.Length < 6)
            {
                PasswordInfo.Text = "Password: Пароль должен быть длинее 5 символов";
            }


            if (!FindSymbols())
                PasswordInfo.Text = "Password: Пароль должен содержвать в себе символы $#!@._-...";

            if (!FindDigits())
                PasswordInfo.Text = "Password: Пароль должен содержвать в себе цифры";

        }
        private bool IsUserExist()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Name == Username.Text)
                {
                    return true;
                }
                if (Users[i].Email == Email.Text)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
