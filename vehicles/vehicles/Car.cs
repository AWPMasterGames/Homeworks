using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car : Mechanism, IMovable
{
    string Name;
    public Car()
    {
        Speed = 10;
        Name = "Car";
    }
    public Car(float speed)
    {
        if (speed < 0) speed = 10;
        Speed = speed;
        Name = "Car";
    }
    public Car(string name,float speed)
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

