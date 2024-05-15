using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._05._2024
{
    internal class Student
    {
        public enum mods
        {
            None = 0,
            Mini = 0,
            Add = 1,
            More = 1,
            Remove = 2
        }
        Random rand = new Random();
        private string _name;
        private string _secondname;
        private string _surename;
        private string _group;
        private int _age;
        private List<int[]> _markList = new List<int[]>();
        private string[] _list = { "программирование", "администрирование", "дизайн" };
        public Student()
        {
            _name = "Ева";
            _secondname = "Криварук";
            _surename = "Викторовна";
            _group = "9Г";
            _age = 16;
            for (int i = 0; i < 3; i++)
            {
                _markList.Add(new int[rand.Next(1, 10)]);
                for (int j = 0; j < _markList[i].Length; j++)
                {
                    _markList[i][j] = rand.Next(1, 12);
                }
            }
        }
        public void CreateMarks(int row)
        {
            if (row < 0 || row > _markList.Count) { return; }

            for (int i = 0; i < _markList[row].Length; i++)
            {
                _markList[row][i] = rand.Next(1, 12);
            }

        }
        public void AddObject(string name, mods mod)
        {
            string[] list = new string[_list.Length + 1];
            switch (mod)
            {
                case mods.None:
                    for (int i = 0; i < list.Length - 1; i++)
                    {
                        list[i] = _list[i];
                    }
                    list[list.Length - 1] = name;
                    _list = list;
                    break;
                case mods.Add:
                    for (int i = 0; i < list.Length - 1; i++)
                    {
                        list[i] = _list[i];
                    }
                    list[list.Length - 1] = name;
                    _list = list;
                    int[] marks = new int[rand.Next(0, 10)];
                    _markList.Add(marks);
                    CreateMarks(_markList.Count - 1);
                    break;
            }
        }
        public void AddObject(string name)
        {
            string[] list = new string[_list.Length + 1];
            for (int i = 0; i < list.Length - 1; i++)
            {
                list[i] = _list[i];
            }
            list[list.Length - 1] = name;
            _list = list;
        }
        public void AddMark(int row, int mark)
        {
            if (row < 0 || row >= _markList.Count) return;
            if (mark < 1) mark = 1;
            if (mark > 12) mark = 12;
            int[] marks = new int[_markList[row].Length + 1];
            for (int i = 0; i < marks.Length - 1; i++)
            {
                marks[i] = _markList[row][i];
            }
            marks[marks.Length - 1] = mark;
            _markList[row] = marks;
        }
        public void ShowObject(mods mod)
        {
            switch (mod)
            {
                case mods.Mini:
                    for (int i = 0; i < _list.Length; i++)
                    {
                        Console.WriteLine($"{_list[i]}:");
                    }
                    Console.WriteLine();
                    break;
                case mods.More:
                    for (int i = 0; i < _list.Length; i++)
                    {
                        Console.WriteLine($"{_list[i]}:");
                        showMarks(i);
                    }
                    Console.WriteLine();
                    break;
            }
        }
        public void ShowObject()
        {
            for (int i = 0; i < _list.Length; i++)
            {
                Console.WriteLine($"{_list[i]}:");
            }
            Console.WriteLine();
        }
        public void Info()
        {
            Console.WriteLine($"Фамилия: {_secondname}\nИмя: {_name}\nОтчество: {_surename}\nГруппа: {_group}\nВозвраст: {_age}");
            ShowObject(mods.More);
            Console.WriteLine("\n");
        }
        private void showMarks(int index)
        {
            for (int i = 0; i < _markList[index].Length; i++)
            {
                Console.Write($"{_markList[index][i]} ");
            }
            Console.WriteLine();
        }
    }
}
