using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        List<IMovable> Objects = new List<IMovable>();

        Tumbleweed tumbleweed = new Tumbleweed();
        Bird bird = new Bird();
        Cat cat = new Cat();
        Airplane airplane = new Airplane();
        Car car = new Car();

        Objects.Add(tumbleweed);
        Objects.Add(bird);
        Objects.Add(cat);
        Objects.Add(airplane);
        Objects.Add(car);

        tumbleweed.Info();
        bird.Info();
        cat.Info();
        airplane.Info();
        car.Info();

        for (int i = 0; i < Objects.Count;i++)
        {
            Objects[i].Move();
        }
    }
}

