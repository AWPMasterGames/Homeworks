using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

namespace Menuski
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LeaderBoard LeaderBoard = new LeaderBoard();
        List<TextBlock> TextBlocks = new List<TextBlock>();
        List<Test> Tests = new List<Test>();
        List<MenuItem> SavedTests = new List<MenuItem>();
        bool _IsPlay;
        enum Phases
        {
            Start,
            Wait,
            End
        }
        private Phases Phase;
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void ReactionBtn(object sender, RoutedEventArgs e)
        {
            if (Phase == Phases.Start)
            {
                //_IsPlay = false;
                //ReactionButton.Background = Brushes.Red;
                //ReactionButton.Content = "Слишком рано";
                return;
            }
            if (Phase == Phases.Wait)
            {
                _IsPlay = false;
                ReactionButton.Background = Brushes.Aqua;
                SaveResultButton.Visibility = Visibility.Visible;
                ResetUser.Visibility = Visibility.Visible;
                ConfirmUserButton.Content = "Start";
                ConfirmUserButton.Visibility = Visibility.Visible;
            }

        }
        private void ResetUserButton(object sender, RoutedEventArgs e)
        {

            UsernameTBlock.Visibility = Visibility.Hidden;
            UsernameTBox.Visibility = Visibility.Visible;
            Phase = Phases.Start;
            ReactionButton.Visibility = Visibility.Hidden;
            SaveResultButton.Visibility = Visibility.Hidden;
            Timer.Visibility = Visibility.Hidden;
            ResetUser.Visibility = Visibility.Hidden;
            ConfirmUserButton.Content = "Confirm";
        }
        
        private void SaveResult(object sender, RoutedEventArgs e)
        {
            SaveResultButton.Visibility = Visibility.Hidden;
            User user = new User(UsernameTBlock.Text, Timer.Text);

            if (LeaderBoard.IsUserExist(user))
            {
                LeaderBoard.AddUser(user);
                UpdateleaderBoard();
                return;
            }

            LeaderBoard.AddUser(user);
            AddUsetInLeaderBoard(user);
            UpdateleaderBoard();
        }
        private void UpdateleaderBoard()
        {
            for (int i = 0; i < TextBlocks.Count; i++)
            {
                TextBlocks[i].Text = $"{LeaderBoard.Users[i].Name}: {LeaderBoard.Users[i].Time}ms";
            }
        }
        private void AddUsetInLeaderBoard(User user)
        {
            TextBlock newTextBlock = new TextBlock();

            newTextBlock.Text = $"{LeaderBoard.Users[LeaderBoard.GetUserIndex(user)].Name}: {LeaderBoard.Users[LeaderBoard.GetUserIndex(user)].Time}ms";
            TextBlocks.Add(newTextBlock);

            LeaderbordViewer.Children.Add(newTextBlock);
        }
        private void ConfirmButton(object sender, RoutedEventArgs e)
        {
            if (UsernameTBox.Text.Length < 3) return;
            UsernameTBlock.Text = UsernameTBox.Text;
            UsernameTBlock.Visibility = Visibility.Visible;
            UsernameTBox.Visibility = Visibility.Hidden;
            Phase = Phases.Start;
            ReactionButton.Visibility = Visibility.Visible;
            SaveResultButton.Visibility = Visibility.Hidden;
            ResetUser.Visibility = Visibility.Hidden;
            ConfirmUserButton.Visibility = Visibility.Hidden;

            TimerStart();
        }
        private void TimerStart()
        {
            Timer.Visibility = Visibility.Visible;
            Timer.Text = "0";
            TimeMove();
        }

        private async void TimeMove()
        {
            //await Task.Delay(new Random().Next(1000, 5000));
            await Task.Delay(new Random().Next(500));

            TimeSpan deltaTime;
            DateTime StartTime = DateTime.Now;
            Phase = Phases.Wait;
            _IsPlay = true;
            ReactionButton.Background = Brushes.Green;
            while (_IsPlay)
            {
                await Task.Delay(1);
                deltaTime = DateTime.Now - StartTime;

                //Timer.Text = $"{deltaTime.Seconds},{deltaTime.Milliseconds}";
                Timer.Text = $"{(int)deltaTime.TotalMilliseconds}";
            }
        }
        private void NewTest(object sender, RoutedEventArgs e)
        {
            newTest();
        }
        private void newTest()
        {
            UsernameTBlock.Visibility = Visibility.Hidden;
            UsernameTBox.Visibility = Visibility.Visible;
            Phase = Phases.Start;
            ReactionButton.Visibility = Visibility.Hidden;
            SaveResultButton.Visibility = Visibility.Hidden;
            Timer.Visibility = Visibility.Hidden;
            ResetUser.Visibility = Visibility.Hidden;
            UsernameTBlock.Text = "";
            UsernameTBox.Text = "";
            ConfirmUserButton.Content = "Confirm";
            LeaderBoard.Users.Clear();
            TextBlocks.Clear();
            LeaderbordViewer.Children.Clear();
        }
        private void SaveTest(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < Tests.Count; i++)
            {
                if(TBoxTestName.Text == Tests[i].Name)
                {
                    TBlockSaveTestName.Text = "Название Теста: Тест с таким названием уже существует";
                    return;
                }
            }
            TBlockSaveTestName.Text = "Название Теста";
            SavedTestes.Visibility = Visibility.Visible;
            Tests.Add(new Test(TBoxTestName.Text,LeaderBoard));
            MenuItem newItem = new MenuItem();
            newItem.Header = $"{TBoxTestName.Text}";
            newItem.Click += LoadTest;

            TextBlock Testname = new TextBlock();
            TextBlock DateSaveTest = new TextBlock();
            MenuItem loadTest = new MenuItem();

            Testname.Text = TBoxTestName.Text;
            DateSaveTest.Text = DateTime.Now.ToString();

            loadTest.Header = "Загрузить тест";
            loadTest.Click += LoadTest;

            TBoxTestName.Text = "";

            newItem.Items.Add(Testname);
            newItem.Items.Add(DateSaveTest);
            newItem.Items.Add(loadTest);

            SavedTestes.Items.Add(newItem);
            SavedTests.Add(newItem);
        }
        private void LoadTest(object sender, RoutedEventArgs e)
        {
            newTest();
            //LeaderBoard = Tests[int.Parse(((MenuItem)sender).Header.ToString())-1].GetLeaderBoard();
            
            for(int i = 0; i < SavedTests.Count; i++)
            {
                if(((MenuItem)SavedTestes.Items[i]).Items[2] == sender)
                //if (((MenuItem)SavedTestes.Items[i]).Items[2] == Tests[i].Name)
                {
                    for(int j = 0; j < Tests[i].GetLeaderBoard().Users.Count; j++)
                    {
                        LeaderBoard.AddUser(Tests[i].GetLeaderBoard().Users[j]);
                        AddUsetInLeaderBoard(Tests[i].GetLeaderBoard().Users[j]);
                    }
                    return;
                }
            }
        }
    }
}
