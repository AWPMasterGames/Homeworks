using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Airplane : Mechanism,IMovable
{
    string Name;
    public Airplane()
    {
        Speed = 10;
        Name = "Airplane";
    }
    public Airplane(float speed)
    {
        if (speed < 0) speed = 10;
        Speed = speed;
        Name = "Airplane";
    }
    public Airplane(string name, float speed)
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

