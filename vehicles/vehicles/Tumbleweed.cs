using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Tumbleweed : IMovable
{
    float Speed;
    public Tumbleweed() => Speed = 10;
    public Tumbleweed(float speed)
    {
        if (speed < 0) speed = 10;
        Speed = speed;
    }
    public void Move()
    {
        Console.WriteLine($"Перекати-Поле перемещаеться со скоростью {Speed}");
    }
    public void Info()
    {
        Console.WriteLine($"Имя: Перекати-Поле, Скорость: {Speed}");
    }
}