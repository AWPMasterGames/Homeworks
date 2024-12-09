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

namespace sapper
{


    public partial class MainWindow : Window
    {
        private Random _random = new Random();

        private int _gameFieldHeight = 10;
        private int _gameFieldWidth = 10;

        private bool[,] _gameField;
        private int _minesNumber;
        private float _minesPercent = 0.15f;
        public MainWindow()
        {
            InitializeComponent();
            GenerateGameField();
            GenerateUIField();
        }

        private void GenerateGameField()
        {
            _gameField = new bool[_gameFieldWidth, _gameFieldHeight];
            _minesNumber = (int)((float)(_gameFieldHeight * _gameFieldWidth) * _minesPercent);
            int minesPastes = 0;
            for (int i = 0; i < _gameFieldWidth; i++)
            {
                if (minesPastes >= _minesNumber)
                {
                    break;
                }

                for (int j = 0; j < _gameFieldWidth; j++)
                {
                    if (_gameField[j, i])
                    {
                        minesPastes++;
                        continue;
                    }
                }
                for (int j = 0; j < _gameFieldHeight; j++)
                {
                    if (_gameField[i, j])
                    {
                        minesPastes++;
                        continue;
                    }
                }
                PasteMineInColumn(i);
                PasteMineInRow(i);
            }

        }
        private void GenerateGameField1()
        {
            _gameField = new bool[_gameFieldWidth, _gameFieldHeight];
            _minesNumber = (int)((float)(_gameFieldHeight * _gameFieldWidth) * _minesPercent);

            for (int i = 0; i < _gameFieldWidth; i++)
            {
                PasteMineInColumn(i);

            }

        }

        private void PasteMineInColumn(int col)
        {

            int row = _random.Next(0, _gameFieldWidth);

            if (_gameField[row, col])
            {
                PasteMineInColumn(col);
            }
            else
            {
                _gameField[row, col] = true;
            }
        }
        private void PasteMineInRow(int row)
        {

            int Column = _random.Next(0, _gameFieldHeight);

            if (_gameField[row, Column])
            {
                PasteMineInRow(row);
            }
            else
            {
                _gameField[row, Column] = true;
            }
        }

        private void GenerateUIField()
        {
            Grid gameField = new Grid();
            GamePanel.Children.Add(gameField);
            gameField.Margin = new Thickness(25, 95, 25, 10);

            for (int i = 0; i < _gameFieldHeight; i++)
            {
                RowDefinition newRow = new RowDefinition();
                gameField.RowDefinitions.Add(newRow);
            }

            for (int i = 0; i < _gameFieldWidth; i++)
            {
                ColumnDefinition newColumn = new ColumnDefinition();
                gameField.ColumnDefinitions.Add(newColumn);
            }

            for (int i = 0; i < _gameFieldHeight; i++)
            {
                for (int j = 0; j < _gameFieldWidth; j++)
                {
                    if (_gameField[i, j])
                    {
                        TextBlock textBlock = new TextBlock();
                        textBlock.Text = "M";
                        textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBlock.Margin = new Thickness(0, 0, 0, 0);
                        textBlock.Width = 20;
                        Grid.SetRow(textBlock, i);
                        Grid.SetColumn(textBlock, j);
                        gameField.Children.Add(textBlock);
                        
                    }
                    else
                    {
                        TextBlock textBlock = new TextBlock();
                        textBlock.Text = "N";
                        textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBlock.Margin = new Thickness(0, 0, 0, 0);
                        textBlock.Width = 20;
                        Grid.SetRow(textBlock, i);
                        Grid.SetColumn(textBlock, j);
                        gameField.Children.Add(textBlock);
                    }
                }
            }


        }
    }
}
