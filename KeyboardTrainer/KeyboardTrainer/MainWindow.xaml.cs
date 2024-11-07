using System.Linq;
using System;
using System.Windows;
using System.Windows.Input;
using System.Threading;

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
            if (Keyboard.IsKeyDown(Key.Q)) { RandomKey('Q'); }
            if (Keyboard.IsKeyDown(Key.W)) { RandomKey('W'); }
            if (Keyboard.IsKeyDown(Key.E)) { RandomKey('E'); }
            if (Keyboard.IsKeyDown(Key.R)) { RandomKey('R'); }
            if (Keyboard.IsKeyDown(Key.T)) { RandomKey('T'); }
            if (Keyboard.IsKeyDown(Key.Y)) { RandomKey('Y'); }
            if (Keyboard.IsKeyDown(Key.U)) { RandomKey('U'); }
            if (Keyboard.IsKeyDown(Key.I)) { RandomKey('I'); }
            if (Keyboard.IsKeyDown(Key.O)) { RandomKey('O'); }
            if (Keyboard.IsKeyDown(Key.P)) { RandomKey('P'); }
            if (Keyboard.IsKeyDown(Key.A)) { RandomKey('A'); }
            if (Keyboard.IsKeyDown(Key.S)) { RandomKey('S'); }
            if (Keyboard.IsKeyDown(Key.D)) { RandomKey('D'); }
            if (Keyboard.IsKeyDown(Key.F)) { RandomKey('F'); }
            if (Keyboard.IsKeyDown(Key.G)) { RandomKey('G'); }
            if (Keyboard.IsKeyDown(Key.H)) { RandomKey('H'); }
            if (Keyboard.IsKeyDown(Key.J)) { RandomKey('J'); }
            if (Keyboard.IsKeyDown(Key.K)) { RandomKey('K'); }
            if (Keyboard.IsKeyDown(Key.L)) { RandomKey('L'); }
            if (Keyboard.IsKeyDown(Key.Z)) { RandomKey('Z'); }
            if (Keyboard.IsKeyDown(Key.X)) { RandomKey('X'); }
            if (Keyboard.IsKeyDown(Key.C)) { RandomKey('C'); }
            if (Keyboard.IsKeyDown(Key.V)) { RandomKey('V'); }
            if (Keyboard.IsKeyDown(Key.B)) { RandomKey('B'); }
            if (Keyboard.IsKeyDown(Key.N)) { RandomKey('N'); }
            if (Keyboard.IsKeyDown(Key.M)) { RandomKey('M'); }
            if (Keyboard.IsKeyDown(Key.Space)) { RandomKey(' '); }
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
    }
}