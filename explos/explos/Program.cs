using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Explosion explosion = null;
            List<Explos> Items = new List<Explos>();
            List<Enemy> Enemys = new List<Enemy>();

            Items.Add(new Explos("Красная бочка", 50));
            Items.Add(new Explos("Динамит", 40));
            Items.Add(new Explos("Граната", 25));

            for (int i = 0; i < Items.Count; i++)
            {
                explosion += Items[i].Explosion;
            }

            Enemys.Add(new Enemy("Ярик", 160));
            Enemys.Add(new Enemy("Вова", 200));
            Enemys.Add(new Enemy("Саня", 100));

            for (int i = 0; i < Enemys.Count; i++)
            {
                Enemys[i].GetDamage(explosion,Mode.HideDamagleMessage);
            }
        }
    }
}
