using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        List<Spell> spells = new List<Spell>();

        spells.Add(new DamageSpell("Огненая спышка", 50, "площади"));
        spells.Add(new DamageSpell("Ледяной шип", 25, "цели"));
        spells.Add(new HealSpell("Исцеление", 25, "цели"));
        spells.Add(new HealSpell("Массовое исцеление", 25, "цели"));
        spells.Add(new DamageSpell("Ментльный червь", 25, "ментали"));

        for(int i = 0; i < spells.Count; i++)
        {
            spells[i].Cast();
        }
    }
}

