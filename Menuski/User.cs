using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class User
{
    private string _Name;
    private string _Time;

    public string Name { get { return _Name; } }
    public string Time { get { return _Time; } }

    public User(string Name, string Time)
    {
        _Name = Name;
        _Time = Time;
    }

    public void ChangeTime(string Time)
    {
        _Time = Time;
    }
}

