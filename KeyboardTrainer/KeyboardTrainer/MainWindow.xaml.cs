using System.Linq;
using System;
using System.Windows;
using System.Windows.Input;
using System.Threading;
using System.Windows.Media;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KeyboardTrainer
{
    internal sealed partial class MainWindow : Window
    {
        bool Turn;
        int SymbolsCount;
        int Failcount;
        int TextDifficulty;
        char[] BlackList = { '+', '-', '*', '/', '(', ')' };
        Char[] Keys = "QWERTYUIOPASDFGHJKLZXCVBNM".ToArray();

        DateTime _lastClickTime;
        DateTime _currentClickTime;
        int _deltasPoolRange = 30;
        int _minimumDeltas = 5;
        List<double> _clicksDeltas = new List<double>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void KeyboardClick(object sender, KeyEventArgs e)
        {
            if (!Turn) return;
            Key key = (Key)e.Key;
            string keyname = key.ToString();
            //if(Keyboard.IsKeyDown(key)) { }
            if (Keyboard.IsKeyDown(Key.Q)) { RandomKey('Q'); ChangeCollor('Q'); }
            if (Keyboard.IsKeyDown(Key.W)) { RandomKey('W'); ChangeCollor('Q'); }
            if (Keyboard.IsKeyDown(Key.E)) { RandomKey('E'); ChangeCollor('E'); }
            if (Keyboard.IsKeyDown(Key.R)) { RandomKey('R'); ChangeCollor('R'); }
            if (Keyboard.IsKeyDown(Key.T)) { RandomKey('T'); ChangeCollor('T'); }
            if (Keyboard.IsKeyDown(Key.Y)) { RandomKey('Y'); ChangeCollor('Y'); }
            if (Keyboard.IsKeyDown(Key.U)) { RandomKey('U'); ChangeCollor('U'); }
            if (Keyboard.IsKeyDown(Key.I)) { RandomKey('I'); ChangeCollor('I'); }
            if (Keyboard.IsKeyDown(Key.O)) { RandomKey('O'); ChangeCollor('O'); }
            if (Keyboard.IsKeyDown(Key.P)) { RandomKey('P'); ChangeCollor('P'); }
            if (Keyboard.IsKeyDown(Key.A)) { RandomKey('A'); ChangeCollor('A'); }
            if (Keyboard.IsKeyDown(Key.S)) { RandomKey('S'); ChangeCollor('S'); }
            if (Keyboard.IsKeyDown(Key.D)) { RandomKey('D'); ChangeCollor('D'); }
            if (Keyboard.IsKeyDown(Key.F)) { RandomKey('F'); ChangeCollor('F'); }
            if (Keyboard.IsKeyDown(Key.G)) { RandomKey('G'); ChangeCollor('G'); }
            if (Keyboard.IsKeyDown(Key.H)) { RandomKey('H'); ChangeCollor('H'); }
            if (Keyboard.IsKeyDown(Key.J)) { RandomKey('J'); ChangeCollor('J'); }
            if (Keyboard.IsKeyDown(Key.K)) { RandomKey('K'); ChangeCollor('K'); }
            if (Keyboard.IsKeyDown(Key.L)) { RandomKey('L'); ChangeCollor('L'); }
            if (Keyboard.IsKeyDown(Key.Z)) { RandomKey('Z'); ChangeCollor('Z'); }
            if (Keyboard.IsKeyDown(Key.X)) { RandomKey('X'); ChangeCollor('X'); }
            if (Keyboard.IsKeyDown(Key.C)) { RandomKey('C'); ChangeCollor('C'); }
            if (Keyboard.IsKeyDown(Key.V)) { RandomKey('V'); ChangeCollor('V'); }
            if (Keyboard.IsKeyDown(Key.B)) { RandomKey('B'); ChangeCollor('B'); }
            if (Keyboard.IsKeyDown(Key.N)) { RandomKey('N'); ChangeCollor('N'); }
            if (Keyboard.IsKeyDown(Key.M)) { RandomKey('M'); ChangeCollor('M'); }
            if (Keyboard.IsKeyDown(Key.Space)) { RandomKey(' '); ChangeCollor(' '); }
        }
        private void TurnOn(object sender, RoutedEventArgs e)
        {
            if (Turn) return;
            Turn = true;
            TextDifficulty = int.Parse(DifficultyText.Text);
            SymbolsCount = 0;
            SubRandomKey1();
            Keyboard.Focus(DifficultySlider);
        }
        private void TurnOff(object sender, RoutedEventArgs e)
        {
            if (!Turn) return;
            Turn = false;
            FailsCount.Text = "0";
            SecondField.Text = "";
            MainField.Text = "";
            SymbolsCount = 0;
            Keyboard.Focus(DifficultySlider);
        }
        private void RandomKey1(char key)
        {
            if (SecondField.Text.ToString()[SecondField.Text.ToString().Length - 1] != key)
            {
                Failcount = int.Parse(FailsCount.Text);
                Failcount++;
                FailsCount.Text = Failcount.ToString();
            }
            MainField.Text = MainField.Text + key;
            SubRandomKey1();
        }
        private void RandomKey(char key)
        {
            /*if (SymbolsCount <= 0)
            {
                SubRandomKey1();
            }*/
            if (SymbolsCount == 0)
            {
                SecondField.Text = SecondField.Text + " ";
                SymbolsCount++;
                SubRandomKey1();
            }
            if (SecondField.Text.ToString()[SecondField.Text.Length - SymbolsCount] != key)
            {
                Failcount = int.Parse(FailsCount.Text);
                Failcount++;
                FailsCount.Text = Failcount.ToString();
            }
            ClickPermMinut();
            MainField.Text = MainField.Text + key;
            SymbolsCount--;
            if (SecondField.Text.Length > 35 & SymbolsCount == 0)
            {
                MainField.Text = "";
                SecondField.Text = "";
                SubRandomKey1();
            }
            if (SymbolsCount == 0)
            {
                SecondField.Text = SecondField.Text + " ";
                SymbolsCount++;
                SubRandomKey1();
            }
        }
        private void SubRandomKey1()
        {
            string temp = "";
            char[] symbols;
            for (int i = 0; i < TextDifficulty; i++)
            {
                temp = temp + Keys[new Random().Next(Keys.Length - 1)];
                Thread.Sleep(3);
            }
            symbols = temp.ToCharArray();
            for (int i = 0; i < new Random().Next(2, 6); i++)
            {
                SymbolsCount++;
                SecondField.Text = SecondField.Text + symbols[new Random().Next(symbols.Length - 1)].ToString();
                Thread.Sleep(3);
            }
        }
        private void SubRandomKey()
        {
            if (SecondField.Text.Length > 40 & SymbolsCount == 1)
            {
                MainField.Text = "";
                SecondField.Text = "";
            }
            SecondField.Text = SecondField.Text + Keys[new Random().Next(Keys.Length - 1)].ToString();
            if (SecondField.Text.ToString().Length > 40)
            {
                char[] temp = SecondField.Text.ToArray();
                SecondField.Text = "";
                for (int i = 1; i < temp.Length; i++)
                {
                    SecondField.Text = SecondField.Text + temp[i].ToString();
                }
            }
            if (MainField.Text.ToString().Length > 39)
            {
                char[] temp = MainField.Text.ToArray();
                MainField.Text = "";
                for (int i = 1; i < temp.Length; i++)
                {
                    MainField.Text = MainField.Text + temp[i].ToString();
                }
            }
        }

        private void PressButton(object sender, RoutedEventArgs e)
        {

        }
        private void DiffSlider(object sender, RoutedEventArgs e)
        {
            DifficultyText.Text = ((int)DifficultySlider.Value).ToString();

        }
        private async void ChangeCollor(char key)
        {
            int time = 50;
            Brush brushes = null;
            switch (key)
            {
                case 'Q':
                    brushes = QBtn.Background;
                    QBtn.Background = Brushes.DarkGray;
                    await Task.Delay(time);
                    QBtn.Background = brushes;
                    break;
                case 'W':
                    brushes = WBtn.Background;
                    WBtn.Background = Brushes.DarkGray;
                    await Task.Delay(time);
                    WBtn.Background = brushes;
                    break;
                case 'E':
                    brushes = EBtn.Background;
                    EBtn.Background = Brushes.DarkGray;
                    await Task.Delay(time);
                    EBtn.Background = brushes;
                    break;
                case 'R':

                    break;

            }
        }
        

        private void ClickPermMinut()
        {
            if (_lastClickTime.Millisecond == 0) _lastClickTime = DateTime.Now;
            _currentClickTime = DateTime.Now;

            _clicksDeltas.Add((_currentClickTime - _lastClickTime).TotalMilliseconds);

            double sum = 0;
            for (int i = 0; i < _clicksDeltas.Count; i++) sum += _clicksDeltas[i];

            if (_clicksDeltas.Count > _minimumDeltas)
                SpeedChar.Text = $"{(int)(60 / ((sum / _clicksDeltas.Count) / 1000))} Символов в минуту";
            else
                SpeedChar.Text = $"Слишком мало нажатий для расчета среднего времени";
            _lastClickTime = _currentClickTime;

            CutClickList();
        }
        private void CutClickList()
        {
            if (_clicksDeltas.Count > _deltasPoolRange)
                _clicksDeltas.RemoveRange(0, _deltasPoolRange / 2);
        }
    }
}
