using System;
using System.Collections.Generic;

namespace Homework_29_04
{
    internal class Program
    {
        static void z1()
        {
            Console.WriteLine("Ведите число: ");
            List<string> Message = new List<string>();
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                z1();
            }
            while (number < 1 || number > 99)
            {
                Console.WriteLine("!!Ошибка: Число должно быть больше 0 и меньше 100!!\nВедите число сново: ");
                number = int.Parse(Console.ReadLine());
            }



            if (number % 3 == 0) Message.Add("Fizz");

            if (number % 5 == 0) Message.Add("Buzz");

            if (number % 3 != 0 && number % 5 != 0) Message.Add($"{number}");

            foreach (string s in Message) Console.WriteLine(s);
        }

        static void z2()
        {
            Console.Write("Ведите число: ");
            float number = float.Parse(Console.ReadLine());

            Console.Write("введите процент: ");
            float percent = float.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {number * (percent / 100)}");
        }
        static void z3()
        {
            int[] Numbers = new int[4];

            Console.Write("Введите первое число: ");
            Numbers[0] = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            Numbers[1] = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            Numbers[2] = int.Parse(Console.ReadLine());

            Console.Write("Введите четвёртое число: ");
            Numbers[3] = int.Parse(Console.ReadLine());

            int result = Numbers[0] * 1000 + Numbers[1] * 100 + Numbers[2] * 10 + Numbers[3];

            Console.WriteLine($"Результат: {result}");
        }
        static void z4()
        {
            Console.Write("Введите число: ");
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
            for (int i = 0; i < number.Length; i++)
            {
                if (i == pos1 - 1)
                {
                    Console.Write(number[pos2 - 1]);
                }
                else if (i == pos2 - 1)
                {
                    Console.Write(number[pos1 - 1]);
                }
                else
                {
                    Console.Write(number[i]);
                }
            }
        }
        static void z7()
        {
            Console.WriteLine("Введите первую границу: ");
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
            }
        }
        static void Main(string[] args)
        {

            //1 задача
            //z1();

            //2 задача
            //z2();

            //3 задача
            //z3();

            //4 задача
            //z4();

            //7 задача
            //z7();
        }
    }
}
