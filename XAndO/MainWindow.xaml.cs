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

namespace XAndO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Difficulty = 0;
        private Game game = new Game();
        private bool IsPvEMode = false;
        private User[] Users = { new Player(), new Player() };
        private int[] RC = new int[2];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PvPMode(object sender, RoutedEventArgs e)
        {
            ViewDifficulty.Content = "Неизвестная";
            DifficultySlider.Visibility = Visibility.Hidden;
            MainMenu.Visibility = Visibility.Hidden;
            SetingGameMenu.Visibility = Visibility.Visible;
            LabelSymbolAsk.Visibility = Visibility.Hidden;
            SelecterX.Visibility = Visibility.Hidden;
            SelecterO.Visibility = Visibility.Hidden;
        }
        private void PvEMode(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            SetingGameMenu.Visibility = Visibility.Visible;
            IsPvEMode = true;
        }
        private void EvEMode(object sender, RoutedEventArgs e)
        {
            MainMenu.Visibility = Visibility.Hidden;
            LabelSymbolAsk.Visibility = Visibility.Hidden;
            SetingGameMenu.Visibility = Visibility.Visible;
            SelecterX.Visibility = Visibility.Hidden;
            SelecterO.Visibility = Visibility.Hidden;
        }


        private void DifficultyChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Difficulty = (int)DifficultySlider.Value;
            switch (Difficulty)
            {
                case 1:
                    ViewDifficulty.Content = "Лёгкая";
                    break;
                case 2:
                    ViewDifficulty.Content = "Нормальная";
                    break;
                case 3:
                    ViewDifficulty.Content = "Сложная";
                    break;
            }
        }
        private void Paste(int row, int col)
        {
            game.Turn(row, col, game.TurnSymbol);
            if (game.SymbolWin != "")
            {
                switch (game.TurnSymbol)
                {
                    case "X":
                        TurnSymbol.Foreground = Brushes.Red;
                        break;
                    case "O":
                        TurnSymbol.Foreground = Brushes.Blue;
                        break;
                }
                TurnSymbol.Content = $"{game.TurnSymbol}";
                TurnSymbolSecond.Text = "Победил:";
                RestartBtn.Visibility = Visibility.Visible;
                MainMenuButton.Visibility = Visibility.Visible;
                IsPvEMode = false;
                return;
            }
            if (game.TurnCount == 9)
            {
                TurnSymbol.Content = $"Никто";
                TurnSymbol.Foreground = Brushes.Gray;
                TurnSymbolSecond.Text = "Победил:";
                RestartBtn.Visibility = Visibility.Visible;
                MainMenuButton.Visibility = Visibility.Visible;
                return;
            }
            switch (game.TurnSymbol)
            {
                case "X":
                    game.TurnSymbol = "O";
                    TurnSymbol.Content = "O";
                    TurnSymbol.Foreground = Brushes.Blue;
                    break;
                case "O":
                    game.TurnSymbol = "X";
                    TurnSymbol.Content = "X";
                    TurnSymbol.Foreground = Brushes.Red;
                    break;
            }
        }

        private void Select1(object sender, RoutedEventArgs e)
        {
            if (btn1.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn1.Content = game.TurnSymbol;
            Paste(0, 0);
            BotTurn();
        }
        private void Select2(object sender, RoutedEventArgs e)
        {
            if (btn2.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn2.Content = game.TurnSymbol;
            Paste(0, 1);
            BotTurn();
        }
        private void Select3(object sender, RoutedEventArgs e)
        {
            if (btn3.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn3.Content = game.TurnSymbol;
            Paste(0, 2);
            BotTurn();

        }
        private void Select4(object sender, RoutedEventArgs e)
        {
            if (btn4.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn4.Content = game.TurnSymbol;
            Paste(1, 0);
            BotTurn();
        }
        private void Select5(object sender, RoutedEventArgs e)
        {
            if (btn5.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn5.Content = game.TurnSymbol;
            Paste(1, 1);
            BotTurn();
        }
        private void Select6(object sender, RoutedEventArgs e)
        {
            if (btn6.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn6.Content = game.TurnSymbol;
            Paste(1, 2);
            BotTurn();
        }
        private void Select7(object sender, RoutedEventArgs e)
        {
            if (game.SymbolWin != "") return;
            if (btn7.Content.ToString() != "") return;
            btn7.Content = game.TurnSymbol;
            Paste(2, 0);
            BotTurn();

        }
        private void Select8(object sender, RoutedEventArgs e)
        {
            if (btn8.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn8.Content = game.TurnSymbol;
            Paste(2, 1);
            BotTurn();
        }
        private void Select9(object sender, RoutedEventArgs e)
        {
            if (btn9.Content.ToString() != "") return;
            if (game.SymbolWin != "") return;
            btn9.Content = game.TurnSymbol;
            Paste(2, 2);
            BotTurn();
        }

        private void StartBtn(object sender, RoutedEventArgs e)
        {
            {
                btn1.Content = "";
                btn2.Content = "";
                btn3.Content = "";
                btn4.Content = "";
                btn5.Content = "";
                btn6.Content = "";
                btn7.Content = "";
                btn8.Content = "";
                btn9.Content = "";
                RestartBtn.Visibility = Visibility.Hidden;
                MainMenuButton.Visibility = Visibility.Hidden;
                TurnSymbolSecond.Text = "Ход:";
                game.Restart();
            }

            if (IsPvEMode)
            {
                PvEModSelect();
            }
            TurnSymbol.Content = "X";
            TurnSymbol.Foreground = Brushes.Red;

            SetingGameMenu.Visibility = Visibility.Hidden;
            GameMenu.Visibility = Visibility.Visible;

            if (Users[0] is Bot)
            {
                BotTurn();
            }
        }
        private void PvEModSelect()
        {
            if (SelecterX.IsChecked.Value)
            {
                Users[1] = new Bot((int)DifficultySlider.Value, "O", "X");
                return;
            }
            Users[0] = new Bot((int)DifficultySlider.Value, "X", "O");
        }
        private void BotTurn()
        {
            if (game.TurnCount >= 9)
            {
                return;
            }
            if (game.SymbolWin != "") return;
            int BotIndex;
            if (Users[0] is Bot)
            {
                BotIndex = 0;
            }
            else BotIndex = 1;
            RC = Users[BotIndex].Turn();
            if (RC[0] == 0 & RC[1] == 0) {
                btn1.Content = game.TurnSymbol;
            }
            else if (RC[0] == 0 & RC[1] == 1)
            {
                btn2.Content = game.TurnSymbol;
            }
            else if (RC[0] == 0 & RC[1] == 2)
            {
                btn3.Content = game.TurnSymbol;
            }
            else if (RC[0] == 1 & RC[1] == 0)
            {
                btn4.Content = game.TurnSymbol;
            }
            else if (RC[0] == 1 & RC[1] == 1)
            {
                btn5.Content = game.TurnSymbol;
            }
            else if (RC[0] == 1 & RC[1] == 2)
            {
                btn6.Content = game.TurnSymbol;
            }
            else if (RC[0] == 2 & RC[1] == 0)
            {
                btn7.Content = game.TurnSymbol;
            }
            else if (RC[0] == 2 & RC[1] == 1)
            {
                btn8.Content = game.TurnSymbol;
            }
            else if (RC[0] == 2 & RC[1] == 2)
            {
                btn9.Content = game.TurnSymbol;
            }
            Paste(RC[0], RC[1]);
        }
        private void MainMenuBtn(object sender, RoutedEventArgs e)
        {
            SetingGameMenu.Visibility = Visibility.Hidden;
            GameMenu.Visibility = Visibility.Hidden;
            MainMenu.Visibility = Visibility.Visible;
        }
    }
}
