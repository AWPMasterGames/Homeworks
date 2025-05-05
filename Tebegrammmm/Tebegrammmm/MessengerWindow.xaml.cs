using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Tebegrammmm.ChatsFoldersRedactsWindows;

namespace Tebegrammmm
{
    /// <summary>
    /// Логика взаимодействия для MessengerWindow.xaml
    /// </summary>
    public partial class MessengerWindow : Window
    {
        User User { get; set; }
        Contact Contact { get; set; }

        TcpClient Client { get; set; }

        TcpListener tcpListener = null;
        Action Action { get; set; }
        Thread Thread { get; set; }
        bool IsRunning { get; set; }
        public MessengerWindow(User user)
        {
            InitializeComponent();
            GridMessege.Visibility = Visibility.Hidden;
            this.User = user;

            LBChatsLoders.ItemsSource = User.ChatsFolders;
            LBChatsLoders.SelectedIndex = 0;

            StartListner();

            Thread = new Thread(new ThreadStart(ReceiveMessage));
            Thread.Start();
        }

        private void StartListner()
        {
            IPEndPoint endP = new IPEndPoint(IPAddress.Any, User.Port);
            tcpListener = new TcpListener(endP);
            tcpListener.Start();
            IsRunning = true;
        }

        private void LBChatsLoders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(LBChatsLoders.SelectedItem == null)
            {
                return;
            }
            LBChats.ItemsSource = (LBChatsLoders.SelectedItem as ChatFolder).Contacts;
        }
        private void LBChats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LBChats.SelectedItem == null)
            {
                return;
            }
            Contact = LBChats.SelectedItem as Contact;
            GridChat.DataContext = Contact;
            LBMessages.ItemsSource = Contact.Messages;
            GridMessege.Visibility = Visibility.Visible;
        }

        void ReceiveMessage()
        {
            try
            {
                while (IsRunning)
                {
                    TcpClient client = tcpListener.AcceptTcpClient();
                    StreamReader sr = new StreamReader(client.GetStream(), Encoding.Unicode);

                    string s = sr.ReadToEnd();

                    string[] messageData = s.Split(';');
                    foreach (Contact contact in User.ChatsFolders[0].Contacts)
                    {
                        if (messageData[0] == contact.IPAddress.ToString() & Convert.ToInt32(messageData[1]) == contact.Port)
                        {
                            Message message = new Message(contact.Name, messageData[3], messageData[2]);
                            this.Dispatcher.BeginInvoke(new Action(() =>
                            {
                                contact.Messages.Add(message);
                            }));
                        }
                    }
                    client.Close();
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Sockets error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void SendMessageToUser(Message message)
        {
            try
            {
                IPEndPoint endP = new IPEndPoint(Contact.IPAddress, Contact.Port);
                Client = new TcpClient();
                Client.Connect(endP);
                NetworkStream nw = Client.GetStream();

                string mes = string.Empty;

                mes += $"{User.IpAddress.ToString()};";
                mes += $"{User.Port};";
                mes += $"{message.Time};";
                mes += $"{message.Text};";

                byte[] buffer = Encoding.Unicode.GetBytes(mes);
                nw.Write(buffer, 0, buffer.Length);
                Client.Close();
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Sockets error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void SendMessage(string message)
        {
            Message Message = new Message(User.Name, message, DateTime.Now.ToString("hh:mm"));
            Contact.Messages.Add(Message);
            SendMessageToUser(Message);
            TBMessage.Text = string.Empty;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LBChats.SelectedItem == null)
            {
                return;
            }
            SendMessage(TBMessage.Text);
            TBMessage.Focus();
        }

        private void TBMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (LBChats.SelectedItem == null)
            {
                return;
            }
            if (e.Key == Key.Enter)
            {
                SendMessage(TBMessage.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Contact newContact = new Contact();
            AddContact addContact = new AddContact(newContact, "Добавить контакт");

            if (addContact.ShowDialog() == true)
            {
                User.ChatsFolders[0].Contacts.Add(newContact);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (LBChats.SelectedItem == null)
            {
                return;
            }
            AddContact addContact = new AddContact(Contact, "Редактировать контакт");

            if (addContact.ShowDialog() == true)
            {
                User.ChatsFolders[0].RemoveContact(Contact);
                User.ChatsFolders[0].AddContact(Contact);
                LBChats.SelectedIndex = LBChats.Items.Count - 1;
                MessageBox.Show("Контакт изменён");
                GridChat.DataContext = Contact;
                TBChat_Name.Text = Contact.Name;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RedactcionChatsFoldersWindow RCFW = new RedactcionChatsFoldersWindow(User.ChatsFolders);
            RCFW.ShowDialog();
        }
    }
}
