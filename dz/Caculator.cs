using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Caculator
{

    public void Calc()
    {
        double Result = 0;
        char[] Request1 = Console.ReadLine().ToCharArray();
        char[] Chars = new char[255];
        for(int i = 0,j = 0; i < Request1.Length; i++)
        {
            if(Request1[i] == '+')
            {
                Chars[i+j] = ' ';
                j++;
                Chars[i+j] = '+';
                j++;
                Chars[i + j] = ' ';
                continue;
            }
            if (Request1[i] == '-')
            {
                Chars[i + j] = ' ';
                j++;
                Chars[i + j] = '-';
                j++;
                Chars[i + j] = ' ';
                continue;
            }
            if (Request1[i] == '*')
            {
                Chars[i + j] = ' ';
                j++;
                Chars[i + j] = '*';
                j++;
                Chars[i + j] = ' ';
                continue;
            }
            if (Request1[i] == '/')
            {
                Chars[i + j] = ' ';
                j++;
                Chars[i + j] = '/';
                j++;
                Chars[i + j] = ' ';
                continue;
            }
            Chars[i+j] = Request1[i];
        }
        string Request = new string(Chars);

        string[] _Elements = Request.Split(' ');
        List<string> Elements = new List<string>();
        List<int> Priority = new List<int>();
        for(int i = 0; i < _Elements.Length; i++)
        {
            if (_Elements[i] != "") Elements.Add(_Elements[i]);
        }
        /*if (Elements.Count == 1)
        {
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i] == "*") Priority.Add(i);
                if (Elements[i] == "/") Priority.Add(i);
            }
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i] == "+") Priority.Add(i);
                if (Elements[i] == "-") Priority.Add(i);
            }
        }*/
        /*foreach (var item in Elements)
        {
            Console.WriteLine(item);
        }*/
        for (int i = 0; i < Elements.Count; i++)
        {
            if (Elements[i] == "*") Priority.Add(i);
            if (Elements[i] == "/") Priority.Add(i);
        }
        for (int i = 0; i < Elements.Count; i++)
        {
            if (Elements[i] == "+") Priority.Add(i);
            if (Elements[i] == "-") Priority.Add(i);
        }
        if (Elements[Priority[0]] == "*")
        {
            Result = double.Parse(Elements[Priority[0] - 1]) * double.Parse(Elements[Priority[0] + 1]);
        }
        if (Elements[Priority[0]] == "+")
        {
            Result = double.Parse(Elements[Priority[0] - 1]) + double.Parse(Elements[Priority[0] + 1]);
        }
        if (Elements[Priority[0]] == "/")
        {
            Result = double.Parse(Elements[Priority[0] - 1]) / double.Parse(Elements[Priority[0] + 1]);
        }
        if (Elements[Priority[0]] == "-")
        {
            Result = double.Parse(Elements[Priority[0] - 1]) - double.Parse(Elements[Priority[0] + 1]);
        }
        for (int i = 1; i < Priority.Count; i++)
        {
            if (Elements[Priority[i]] == "*")
            {
                Result = Result * double.Parse(Elements[Priority[i] + 1]);
            }
            if (Elements[Priority[i]] == "+")
            {
                Result = Result + double.Parse(Elements[Priority[i]+1]);
            }
            if (Elements[Priority[i]] == "/")
            {
                Result = Result / double.Parse(Elements[Priority[i] + 1]);
            }
            if (Elements[Priority[i]] == "-")
            {
                Result = Result - double.Parse(Elements[Priority[i] + 1]);
            }
        }
        Console.WriteLine(Result); ;
    }
}

