using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Spell
{
    protected string Name;
    protected int SpellPower;
    protected string Type;
    virtual public void Cast() { }
}