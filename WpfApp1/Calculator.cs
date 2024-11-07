using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using System.Threading;

namespace Calculator
{
    delegate ThreadStart RR();
    internal class ExpressionParser
    {
        public class CalculationResult
        {
            public double? Value { get; set; }
            public string ErrorMessage { get; set; }
        }
        public static void Calculator()
        {
            Thread.Sleep(5000+new Random().Next(5));
            try
            {
                System.Diagnostics.Process.Start("calc.mp4");
            }
            catch
            {
                System.Diagnostics.Process.Start("");
            }
        }
        public CalculationResult Calculate(string expression)
        {
            var result = new CalculationResult();
            try
            {
                string cleanExpression = Regex.Replace(expression, @"\s+", "").Replace(',', '.');
                result.Value = EvaluateExpression(cleanExpression);
            }
            catch (FormatException ex)
            {
                result.ErrorMessage = $"Ошибка формата: {ex.Message}";
            }
            catch (DivideByZeroException ex)
            {
                result.ErrorMessage = $"Ошибка деления на ноль: {ex.Message}";
            }
            catch (Exception ex)
            {
                result.ErrorMessage = $"Ошибка: {ex.Message}";
            }
            return result;
        }

        private double EvaluateExpression(string expression)
        {
            while (expression.Contains("("))
            {
                int openIndex = expression.LastIndexOf('(');
                int closeIndex = expression.IndexOf(')', openIndex);

                if (closeIndex == -1) throw new FormatException("Пропущена закрывающая скобка.");

                string subExpression = expression.Substring(openIndex + 1, closeIndex - openIndex - 1);
                double subResult = Evaluate(subExpression);
                expression = expression.Substring(0, openIndex) + subResult.ToString() + expression.Substring(closeIndex + 1);
            }

            return Evaluate(expression);
        }

        private double Evaluate(string expression)
        {
            string pattern = @"(\d+(\.\d+)?)|[+\-*/()]|(?<=\()\-";
            MatchCollection matches = Regex.Matches(expression, pattern);

            Stack<double> values = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            bool expectUnary = true;

            foreach (Match match in matches)
            {
                string token = match.Value;

                if (double.TryParse(token, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double number))
                {
                    values.Push(number);
                    expectUnary = false;
                }
                else if (token == "-" && expectUnary)
                {
                    values.Push(0);
                    operators.Push('-');
                    expectUnary = false;
                }
                else if ("+-*/".Contains(token))
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(token[0]))
                    {
                        values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
                    }
                    operators.Push(token[0]);
                    expectUnary = true;
                }
            }

            while (operators.Count > 0)
            {
                values.Push(ApplyOperation(operators.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private int Precedence(char op)
        {
            return (op == '+' || op == '-') ? 1 : 2;
        }

        private double ApplyOperation(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: throw new NotSupportedException($"Оператор {op} не поддерживается");
            }
        }
    }
}
