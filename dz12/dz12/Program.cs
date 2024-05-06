using System;

namespace Homework_29_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 задача
            /*Console.WriteLine("Ведите число: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 0 || number > 100)
            {
                Console.WriteLine("!!ошибка!!\nведите число сново: ");
                number = int.Parse(Console.ReadLine());
            }

            if (number % 3 == 0 && number % 5 != 0) Console.Write("Fizz");
            if (number % 5 == 0 && number % 3 != 0) Console.Write("Buzz");
            if (number % 3 == 0 && number % 5 == 0) Console.Write("Fizz Buzz");
            if (number % 3 != 0 && number % 5 != 0) Console.WriteLine(number);*/


            //2 задача
            /*Console.Write("Ведите число: ");
            float number = float.Parse(Console.ReadLine());

            Console.Write("введите процент: ");
            float percent = float.Parse(Console.ReadLine());

            Console.WriteLine("Результат: " + (number * (percent / 100)));*/

            //3 задача
            /*Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("введите третье число: ");
            int number3 = int.Parse(Console.ReadLine());

            Console.Write("введите четвёртое число: ");
            int number4 = int.Parse(Console.ReadLine());

            int result = number1 * 1000 + number2 * 100 + number3 * 10 + number4;

            Console.WriteLine("The result is " + result);*/

            //4 задача
            /*Console.Write("Введите число: ");
            string number = Console.ReadLine();
            while (number.Length != 6)
            {
                Console.Write("ERROR!!!\nВведите число сново: ");
                number = Console.ReadLine();
            }
            Console.Write("Введите первую позицию: ");
            int pos1 = int.Parse(Console.ReadLine());
            Console.Write("Введите вторую позицию: ");
            int pos2 = int.Parse(Console.ReadLine());
            for (int i = 0;i < number.Length; i++)
            {
                if (i == pos1-1)
                {
                    Console.Write(number[pos2-1]);
                }
                else if (i == pos2-1)
                {
                    Console.Write(number[pos1-1]);
                }
                else
                {
                    Console.Write(number[i]);
                }
            }*/

            //7 задача
            /*Console.WriteLine("Введите первую границу: ");
            int left = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую границу: ");
            int right = int.Parse(Console.ReadLine());
            while (left > right)
            {
                Console.WriteLine("!!ошибка!!\nведите границу сново: ");
                left = int.Parse(Console.ReadLine());
                Console.WriteLine("!!ошибка!!\nведите вторую грань сново: ");
                right = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Четные числа из " + left + " в " + right + ": ");
            for (int i = left; i <= right; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }*/
        }
    }
}