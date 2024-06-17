using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DamageSpell : Spell
{
    public DamageSpell(string name,int spellPower,string type)
    {
        Name = name;
        SpellPower = spellPower;
        Type = type;
    }
    public override void Cast() {
        Console.WriteLine($"Заклинание {Name} нанесло {SpellPower} Урона по {Type}");
    }
}