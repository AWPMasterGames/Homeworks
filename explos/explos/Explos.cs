using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Mode
{
    ShowDamagleMessage = 0,
    HideDamagleMessage = 1
}

delegate int Explosion(Mode mode = Mode.HideDamagleMessage);

internal class Explos
{
    string _Name;
    int _Damage;
    public string Name {  get { return _Name; } }
    public int Damage { get { return _Damage; } }
    public Explos(string name, int damage)
    {
        _Name = name;
        _Damage = damage;
    }
    public int Explosion(Mode mode = Mode.HideDamagleMessage) {
        if (mode == Mode.ShowDamagleMessage) Console.Write($"{_Damage} урона от {_Name}");
        else if (mode == Mode.HideDamagleMessage) { }
        return _Damage; 
    }
}

