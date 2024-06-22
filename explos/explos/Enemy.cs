using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Enemy
{
    string _Name;
    int _Health;

    public string Name { get { return _Name; } }
    public int Health { get { return _Health; } }

    public Enemy(string name, int health)
    {
        _Name = name;
        _Health = health;
    }

    public void GetDamage(Explosion obj, Mode mode = Mode.HideDamagleMessage)
    {
        if(obj == null) return;
        foreach(Explosion Ex in obj.GetInvocationList())
        {
            if(mode == Mode.ShowDamagleMessage) Console.Write($"{_Name} Получил ");
            _Health -= Ex(mode);
            if(mode == Mode.ShowDamagleMessage) Console.WriteLine();
        }
        if(_Health <= 0) { Console.WriteLine($"{_Name} Умер"); }
        else if(_Health > 0) { Console.WriteLine($"{_Name} выжил c {_Health} HP"); }
    }
}
