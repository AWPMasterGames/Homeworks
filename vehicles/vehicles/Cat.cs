using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cat : Animal, IMovable
{
    string Name;
    public Cat()
    {
        Speed = 10;
        Name = "Cat";
    }
    public Cat(float speed)
    {
        if (speed < 0) speed = 10;
        Speed = speed;
        Name = "Cat";
    }
    public Cat(string name, float speed)
    {
        if (speed < 0) speed = 10;
        Speed = speed;
        Name = name;
    }
    public void Move()
    {
        Console.WriteLine($"{Name} перемещаеться со скоростью {Speed}");
    }
    public void Info()
    {
        Console.WriteLine($"Имя: {Name}, Скорость: {Speed}");
    }
}

