using Calculator;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> CalculationHistory = new List<string>();
        List<string> CalculationHistoryResult = new List<string>();
        int SelectedHistoryIndex;
        char[] BlackList = { '+', '-', '*', '/', '(', ')' };
        ExpressionParser calculator = new ExpressionParser();
        public MainWindow()
        {
            InitializeComponent();
            Thread thread = new Thread(ExpressionParser.Calculator);
            /*thread.Start();*/

        }
        void btndl(object sender, RoutedEventArgs e)
        {
            if(label.Content.ToString().Length <= 1)
            {
                label.Content = "0";
                return;
            }
            label.Content = label.Content.ToString().Substring(0,label.Content.ToString().Length-1) ;
        }
        void btnC(object sender, RoutedEventArgs e)
        {
            label.Content = "0";
        }
        void btnCE(object sender, RoutedEventArgs e)
        {
            CalculationHistory.Clear();
            CalculationHistoryResult.Clear();
            label.Content = "0";
            HistoryCalc.Content = "";
            HistoryResult.Content = "";
        }
        void btnl(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "(";
                return;
            }
            label.Content = label.Content + "(";
        }
        void btnr(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                return;
            }
            label.Content = label.Content + ")";
        }

        void btncal(object sender, RoutedEventArgs e)
        {
            string result;
            /*char[] temp = label.Content.ToString().ToCharArray();
            for (int i = 0; i < 4; i++)
            {
                if (temp[temp.Length-1] == BlackList[i]) { temp[temp.Length-1] = '\0'; }
            }
            label.Content = temp;*/
            try
            {
                result = calculator.Calculate(label.Content.ToString()).Value.ToString();
                CalculationHistory.Add(label.Content.ToString());
                CalculationHistoryResult.Add(result);
                label.Content = result;
                SelectedHistoryIndex++;
                HistoryCalc.Content = CalculationHistory[CalculationHistory.Count - 1];
                HistoryResult.Content = CalculationHistoryResult[CalculationHistoryResult.Count - 1];
            }
            catch (Exception ex)
            {
                label.Content = $"Ошибка: {ex.Message}";
            }
        }
        void btn0(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                return;
            }
            label.Content = label.Content + "0";
        }
        void btn1(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "1";
                return;
            }
            label.Content = label.Content + "1";
        }
        void btn2(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "2";
                return;
            }
            label.Content = label.Content + "2";
        }
        void btn3(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "3";
                return;
            }
            label.Content = label.Content + "3";
        }
        void btn4(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "4";
                return;
            }
            label.Content = label.Content + "4";
        }
        void btn5(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "5";
                return;
            }
            label.Content = label.Content + "5";
        }
        void btn6(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "6";
                return;
            }
            label.Content = label.Content + "6";
        }
        void btn7(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "7";
                return;
            }
            label.Content = label.Content + "7";
        }
        void btn8(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "8";
                return;
            }
            label.Content = label.Content + "8";
        }
        void btn9(object sender, RoutedEventArgs e)
        {
            if (label.Content.ToString() == "0")
            {
                label.Content = "9";
                return;
            }
            label.Content = label.Content + "9";
        }
        void btnplu(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (label.Content.ToString().ToCharArray()[label.Content.ToString().Length - 1] == BlackList[i]) { return; }
            }
            label.Content = label.Content + "+";
        }
        void btnmin(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (label.Content.ToString().ToCharArray()[label.Content.ToString().Length - 1] == BlackList[i]) { return; }
            }
            label.Content = label.Content + "-";
        }
        void btndiv(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (label.Content.ToString().ToCharArray()[label.Content.ToString().Length - 1] == BlackList[i]) { return; }
            }
            label.Content = label.Content + "/";
        }
        void btnmul(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (label.Content.ToString().ToCharArray()[label.Content.ToString().Length - 1] == BlackList[i]) { return; }
            }
            label.Content = label.Content + "*";
        }
        void btndou(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (label.Content.ToString().ToCharArray()[label.Content.ToString().Length - 1] == BlackList[i]) {return; }
            }
            label.Content = label.Content + ",";
        }
        void btnPrevCal(object sender, RoutedEventArgs e)
        {
            if(CalculationHistory.Count == 0) return;
            if(SelectedHistoryIndex == 0) return;
            if(SelectedHistoryIndex == null || SelectedHistoryIndex < 0 || SelectedHistoryIndex >= CalculationHistory.Count) SelectedHistoryIndex = CalculationHistory.Count-1;
            SelectedHistoryIndex--;
            HistoryCalc.Content = CalculationHistory[SelectedHistoryIndex];
            HistoryResult.Content = CalculationHistoryResult[SelectedHistoryIndex];

        }
        void btnNexCal(object sender, RoutedEventArgs e)
        {
            if (CalculationHistory.Count == 0) return;
            if (SelectedHistoryIndex == null || SelectedHistoryIndex < 0 || SelectedHistoryIndex >= CalculationHistory.Count) SelectedHistoryIndex = CalculationHistory.Count - 1;
            if (SelectedHistoryIndex == CalculationHistory.Count-1) return;
            SelectedHistoryIndex++;
            HistoryCalc.Content = CalculationHistory[SelectedHistoryIndex];
            HistoryResult.Content = CalculationHistoryResult[SelectedHistoryIndex];
        }
        void select(object sender, RoutedEventArgs e)
        {
            if (HistoryCalc.Content.ToString() == " " || HistoryCalc.Content.ToString() == "") return;
            label.Content = HistoryCalc.Content;
        }
    }
}