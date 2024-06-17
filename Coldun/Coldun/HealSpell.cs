using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class HealSpell : Spell
{
    public HealSpell(string name, int spellPower, string type)
    {
        Name = name;
        SpellPower = spellPower;
        Type = type;
    }
    public override void Cast()
    {
        Console.WriteLine($"Заклинание {Name} исцелил {SpellPower} здоровья по {Type}");
    }
}