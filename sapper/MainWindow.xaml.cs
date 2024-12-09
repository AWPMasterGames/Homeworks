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

    enum Item
    {
        None, Mine, Number
    }

    public partial class MainWindow : Window
    {
        private Random _random = new Random();

        private TextBlock[,] _tBlockGameField;
        private Button[,] _FieldButtons;

        private Grid _gameFieldGrid;

        private int _gameFieldHeight = 20;
        private int _gameFieldWidth = 15;


        private Item[,] _gameField;

        private int _clicks = 0;

        private int _minesNumber;
        private float _minesPercent = 0.15f;
        public MainWindow()
        {
            InitializeComponent();

            NewField();
        }
        private void NewField()
        {
            GenerateButtonField();
            
            
        }
        private void GenerateGameField()
        {
            _gameField = new Item[_gameFieldHeight, _gameFieldWidth];
            _minesNumber = (int)((float)(_gameFieldHeight * _gameFieldWidth) * _minesPercent);
            int minesPastes = 0;
            for (int i = 0; i < _gameFieldWidth; i++)
            {
                if (minesPastes >= _minesNumber)
                {
                    break;
                }
                

                PasteMineInColumn(i);
                minesPastes++;
                PasteMineInRow(i);
                minesPastes++;
            }

        }
        private void GenerateButtonField()
        {
            Grid gameField = new Grid();
            _FieldButtons = new Button[_gameFieldHeight, _gameFieldWidth];
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
                    Button newbutton = new Button();
                    newbutton.Click += Button_click;
                    Grid.SetRow(newbutton,i);
                    Grid.SetColumn(newbutton,j);
                    Panel.SetZIndex(newbutton, 1);
                    gameField.Children.Add(newbutton);
                    _FieldButtons[i,j] = newbutton;
                }
            }
            Grid.SetRow(gameField, 1);
            Grid.SetRowSpan(gameField, 2);
            Grid.SetColumn(gameField, 0);
            Grid.SetColumnSpan(gameField, 3);
            _gameFieldGrid = gameField;
            GamePanel.Children.Add(_gameFieldGrid);
        }
        private void GenerateUIField()
        {
            _tBlockGameField = new TextBlock[_gameFieldHeight, _gameFieldWidth];

            for (int i = 0; i < _gameFieldHeight; i++)
            {
                for (int j = 0; j < _gameFieldWidth; j++)
                {
                    if (_gameField[i, j] == Item.Mine)
                    {
                        TextBlock textBlock = new TextBlock();
                        textBlock.Text = "X";
                        textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBlock.Margin = new Thickness(2, 2, 2, 2);
                        
                        textBlock.FontSize = 15;
                        textBlock.Background = Brushes.Red;
                        Grid.SetRow(textBlock, i);
                        Grid.SetColumn(textBlock, j);
                        Panel.SetZIndex(textBlock, 0);
                        _gameFieldGrid.Children.Add(textBlock);
                        _tBlockGameField[i, j] = textBlock;
                    }
                    else
                    {
                        TextBlock textBlock = new TextBlock();
                        textBlock.Text = "";
                        textBlock.HorizontalAlignment = HorizontalAlignment.Center;
                        textBlock.VerticalAlignment = VerticalAlignment.Center;
                        textBlock.Margin = new Thickness(2, 2, 2, 2);
                        textBlock.Width = 20;
                        textBlock.FontSize = 15;
                        Grid.SetRow(textBlock, i);
                        Grid.SetColumn(textBlock, j);
                        Panel.SetZIndex(textBlock, 0);
                        _gameFieldGrid.Children.Add(textBlock);
                        _tBlockGameField[i, j] = textBlock;
                    }
                }
            }

            CheckFieldItems();
        }
        private void CheckFieldItems()
        {
            for (int i = 0; i < _gameFieldHeight; i++)
            {
                for (int j = 0; j < _gameFieldWidth; j++)
                {
                    if (_gameField[i, j] == Item.None || _gameField[i, j] == Item.Number)
                    {
                        SetNumberCells(i, j);
                    }
                }
            }
        }

        private void SetNumberCells(int row, int col)
        {
            int mines = 0;

            List<int[]> indexes = new List<int[]>();
            indexes.Add(new int[] { row - 1, col - 1 });
            indexes.Add(new int[] { row - 1, col });
            indexes.Add(new int[] { row - 1, col + 1 });

            indexes.Add(new int[] { row, col - 1 });
            indexes.Add(new int[] { row, col + 1 });

            indexes.Add(new int[] { row + 1, col - 1 });
            indexes.Add(new int[] { row + 1, col });
            indexes.Add(new int[] { row + 1, col + 1 });

            for (int i = 0; i < indexes.Count; i++)
            {
                int[] index = indexes[i];
                try
                {
                    switch (_gameField[index[0], index[1]])
                    {
                        case Item.Mine:
                            mines++;
                            break;
                    }
                }
                catch
                {
                    continue;
                }
            }

            if (mines > 0)
            {
                _tBlockGameField[row, col].Text = $"{mines}";
            }

        }

        private void PasteMineInColumn(int col)
        {

            int row = _random.Next(0, _gameFieldHeight);

            if (_gameField[row, col] == Item.Mine)
            {
                PasteMineInColumn(col);
            }
            else
            {
                _gameField[row, col] = Item.Mine;
            }
        }
        private void PasteMineInRow(int row)
        {

            int col = _random.Next(0, _gameFieldWidth);

            if (_gameField[row, col] == Item.Mine)
            {
                PasteMineInColumn(col);
            }
            else
            {
                _gameField[row, col] = Item.Mine;
            }
        }

        private void ButtonClickHandler(Button button)
        {
            button.Visibility = Visibility.Hidden;
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            if (_clicks == 0)
            {
                GenerateGameField();
                GenerateUIField();
            }
            _clicks++;
            ButtonClickHandler((Button)sender);
        }
        private void OpenFieldButton(object sender, RoutedEventArgs e)
        {
            foreach(var button in _FieldButtons) button.Visibility = Visibility.Hidden;
        }
    }
}
