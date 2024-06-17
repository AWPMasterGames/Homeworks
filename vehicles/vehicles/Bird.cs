using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Bird : Animal, IMovable
{
    string Name;
    public Bird()
    {
        Speed = 10;
        Name = "Bird";
    }
    public Bird(float speed)
    {
        if (speed < 0) speed = 10;
        Speed = speed;
        Name = "Bird";
    }
    public Bird(string name, float speed)
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
