using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Player
{
    protected int _Number;

    public virtual int GetNumber()
    {
        return _Number;
    }
}

