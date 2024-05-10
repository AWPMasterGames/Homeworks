using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _6._05._2024
{
    internal class Program
    {
        public static Random rnd = new Random();
        public static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        /*public static void RandArray<T>(T[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {

                a[i] = rnd.NextDouble() * 100;
            }
        }*/
        public static void PrintArray<T>(T[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void PrintArray<T>(T[] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
        /*static void Print2DArray(double[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.Write("{2} ", i, j, arr[i, j]);
                }
                Console.WriteLine();
            }
        }*/
        static void z1()
        {
            Console.WriteLine("Задиние 1");

            int[] A = { 1, 5, 7, 3, 67 };
            double[,] B = new double[3, 4];

            PrintArray(A);
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rnd.NextDouble() * 100;
                }
            }
            PrintArray(B);
            Console.WriteLine("\n\n");
        }
        static string cipher(string s)
        {

            return s;
        }
        static void z2()
        {
            Console.WriteLine("Задание 2");
            int[,] arr = new int[5, 5];
            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rnd.Next(-100,100);
                }
            }
            PrintArray(arr);
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i,j];
                }
            }
            Console.WriteLine($"Сумма {sum}");
            Console.WriteLine("\n\n");

        }
        static string Encrypt(char[] text, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int length = text.Length;
            char[] encryptedMessage = new char[length];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    var letter = text[i];
                    int index = Array.IndexOf(alphabet, letter);
                    int newIndex = (key + index) % 26;
                    char newLetter = alphabet[newIndex];
                    encryptedMessage[i] = newLetter;
                }
                else
                {
                    encryptedMessage[i] = text[i];
                }
            }

            string enMessage = String.Join("", encryptedMessage);
            return enMessage;
        }
        static string Decrypt(char[] text, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int length = text.Length;
            char[] encryptedMessage = new char[length];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] <= 'z')
                {
                    var letter = text[i];
                    int index = Array.IndexOf(alphabet, letter);
                    int newIndex = (index - key) % 26;
                    char newLetter = alphabet[newIndex];
                    encryptedMessage[i] = newLetter;
                }
                else
                {
                    encryptedMessage[i] = text[i];
                }
            }

            string enMessage = String.Join("", encryptedMessage);
            return enMessage;
        }
        static void z3()
        {
            Console.WriteLine("Задание 3");

            string text = "Hello World!!!";

            string text1 = text.ToLower();
            char[] stext = text1.ToCharArray();

            string cipi = Encrypt(stext, 3);
            Console.WriteLine(cipi);

            string cipi1 = Decrypt(cipi.ToCharArray(),3);
            Console.WriteLine(cipi1);

            Console.WriteLine("\n\n");
        }
        static int Evaluate(string expression)
        {
            string[] temp = expression.Split();
            int result = 0;
            if (temp[1] == "+")
            {
                result = int.Parse(temp[0]) + int.Parse(temp[2]);
            }
            else if (temp[1] == "-")
            {
                result = int.Parse(temp[0]) - int.Parse(temp[2]);
            }
            return result;
        }
        static void z4()
        {
            Console.WriteLine("Задание 5");

            string expression = "6 - 5 =";
            Console.WriteLine(expression + Evaluate(expression));
            Console.ReadLine();

            Console.WriteLine("\n\n");
        }
        static void z7()
        {
            Console.WriteLine("Задание 7");

            string text = "To be, or not to be, that is the question,\n" +
                          "Whether 'tis nobler in the mind to suffer\n" +
                          "The slings and arrows of outrageous fortune,\n" +
                          "Or to take arms against a sea of troubles,\n" +
                          "And by opposing end them? To die: to sleep;\n" +
                          "No more; and by a sleep to say we end\n" +
                          "The heart-ache and the thousand natural shocks\n" +
                          "That flesh is heir to, 'tis a consummation\n" +
                          "Devoutly to be wish'd. To die, to sleep";

            string BanWord = "die";
            string replacement = "***";

            int replacedWordsCount = 0;

            string newText = text;
            while (true)
            {
                string tempText = newText;
                newText = Regex.Replace(newText, $"\\b{BanWord}\\b", replacement, RegexOptions.IgnoreCase);
                if (tempText == newText)
                {
                    replacedWordsCount++;
                    break;
                }
                replacedWordsCount++;
            }

            Console.WriteLine("Текст до:");
            Console.WriteLine(text);
            Console.WriteLine("\nТекст после:");
            Console.WriteLine(newText);
            Console.WriteLine($"\nСтатистика: {replacedWordsCount} замены слова '{BanWord}'.");

            Console.WriteLine("\n\n");
        }
        static void Main(string[] args)
        {
            z7();

        }
    }
}
