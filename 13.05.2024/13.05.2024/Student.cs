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
            Mini = 1,
            Add = 2,
            More = 3,
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
            for (int i = 0; i < _list.Length; i++)
            {
                _markList.Add(new int[rand.Next(1, 10)]);
                for (int j = 0; j < _markList[i].Length; j++)
                {
                    _markList[i][j] = rand.Next(1, 5);
                }
            }
        }
        public Student(string name,string secondname,string surename)
        {
            _name = name;
            _secondname = secondname;
            _surename = surename;
            _group = "9Г";
            _age = 16;
            for (int i = 0; i < _list.Length; i++)
            {
                _markList.Add(new int[rand.Next(1, 10)]);
                for (int j = 0; j < _markList[i].Length; j++)
                {
                    _markList[i][j] = rand.Next(1, 5);
                }
            }
        }
        public Student(string name, string secondname, string surename,int age)
        {
            _name = name;
            _secondname = secondname;
            _surename = surename;
            _group = "9Г";
            _age = age;
            for (int i = 0; i < _list.Length; i++)
            {
                _markList.Add(new int[rand.Next(1, 10)]);
                for (int j = 0; j < _markList[i].Length; j++)
                {
                    _markList[i][j] = rand.Next(1, 5);
                }
            }
        }
        public Student(string name, string secondname, string surename, int age,string group)
        {
            _name = name;
            _secondname = secondname;
            _surename = surename;
            _group = group;
            _age = age;
            for (int i = 0; i < _list.Length; i++)
            {
                _markList.Add(new int[rand.Next(1, 10)]);
                for (int j = 0; j < _markList[i].Length; j++)
                {
                    _markList[i][j] = rand.Next(1, 5);
                }
            }
        }
        public Student(string name, string secondname, string surename, int age, string group,string[] list)
        {
            _name = name;
            _secondname = secondname;
            _surename = surename;
            _group = group;
            _age = age;
            _list = list;
            for (int i = 0; i < _list.Length; i++)
            {
                _markList.Add(new int[rand.Next(1, 10)]);
                for (int j = 0; j < _markList[i].Length; j++)
                {
                    _markList[i][j] = rand.Next(1, 5);
                }
            }
        }
        public void GPA(int row)
        {
            if (row < 0 || row >= _list.Length) return;
            Console.WriteLine($"Средний балл по {_list[row]}: {gpa(row)}");
        }
        public void CreateMarks(int index)
        {
            if (index < 0 || index >= _markList.Count) { return; }

            for (int i = 0; i < _markList[index].Length; i++)
            {
                _markList[index][i] = rand.Next(1, 5);
            }

        }
        public void RemoveObject(int index)
        {
            if(index < 0 || index > _list.Length) { return; }
            string[] list = new string[_list.Length-1];
            for (int i = 0;i < index; i++)
            {
                list[i] = _list[i];
            }
            for (int i = index; i < list.Length; i++)
            {
                list[i] = _list[i+1];
            }
            _list = list;
            _markList.Remove(_markList[index]);
        }
        public void RemoveObject()
        {
            string[] newlist = new string[_list.Length-1];
            for (int i = 0;i < newlist.Length; i++)
            {
                newlist[i] = _list[i];
            }
            _list = newlist;
            _markList.Remove(_markList[_markList.Count - 1]);
        }
        public void ChangeMark(int row, int col,int mark)
        {
            if(row < 0 || row >= _markList.Count) return;
            if(col < 0 || col >= _markList[row].Length) return;
            if (mark < 1) mark = 1;
            if (mark > 5) mark = 5;
            _markList[row][col] = mark;
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
                    int[] marks1 = { rand.Next(1, 5) };
                    _markList.Add(marks1);
                    
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
            int[] marks1 = new int[0];
            _markList.Add(marks1);
        }
        public void AddMark(int index, int mark)
        {
            if (index < 0 || index >= _markList.Count) return;
            if (mark < 1) mark = 1;
            if (mark > 5) mark = 5;
            
            int[] marks = new int[_markList[index].Length + 1];
            for (int i = 0; i < marks.Length - 1; i++)
            {
                marks[i] = _markList[index][i];
            }
            marks[marks.Length - 1] = mark;
            _markList[index] = marks;
        }
        public void ShowObject(mods mod)
        {
            switch (mod)
            {
                case mods.Mini:
                    for (int i = 0; i < _list.Length; i++)
                    {
                        Console.WriteLine($"{_list[i]}: GPA {gpa(i)}");
                    }
                    Console.WriteLine();
                    break;
                case mods.More:
                    for (int i = 0; i < _list.Length; i++)
                    {
                        Console.WriteLine($"{_list[i]}: GPA {gpa(i)}");
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
        public void ShowObject(int index)
        {
            Console.WriteLine($"{_list[index]}:");
            showMarks(index);

            Console.WriteLine();
        }

        public void Info()
        {
            Console.WriteLine($"Фамилия: {_secondname}\nИмя: {_name}\nОтчество: {_surename}\nГруппа: {_group}\nВозвраст: {_age}");
            ShowObject(mods.Mini);
            Console.WriteLine("\n");
        }
        public void Info(mods mod)
        {
            switch (mod) {
                case mods.Mini:
                    Console.WriteLine($"Фамилия: {_secondname}\nИмя: {_name}\nОтчество: {_surename}\nГруппа: {_group}\nВозвраст: {_age}");
                    ShowObject(mods.Mini);
                    Console.WriteLine("\n");
                    break;
                case mods.More:
                    Console.WriteLine($"Фамилия: {_secondname}\nИмя: {_name}\nОтчество: {_surename}\nГруппа: {_group}\nВозвраст: {_age}");
                    ShowObject(mods.More);
                    Console.WriteLine("\n");
                    break;
            }
        }
        private void showMarks(int index)
        {
            if(index < 0 || index >= _markList.Count) { return; }
            for (int i = 0; i < _markList[index].Length; i++)
            {
                Console.Write($"{_markList[index][i]} ");
            }
            Console.WriteLine();
        }
        private int gpa(int row)
        {
            if (row < 0 || row >= _markList.Count) {  return 0; }
            int gpa = 0;
            for (int i = 0; i < _markList[row].Length; i++)
            {
                gpa += _markList[row][i];
            }
            gpa = gpa / _markList[row].Length;
            return gpa;
        }
    }
}
