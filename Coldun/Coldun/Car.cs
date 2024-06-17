using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coldun
{
    internal class Car
    {
        private string _Mark;
        private int _Cost;
        public string Mark { get { return Mark; } }
        public int Cost { get { return _Cost; } }
        public Car(string mark, int cost)
        {
            _Mark = mark;
            _Cost = cost;
        }
        public string GetMark() { return _Mark; }
        public void Info() {
            Console.WriteLine($"Марка: {_Mark}, Цена {_Cost}");
        }
    }
}
