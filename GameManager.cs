using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class GameManager
{
    public static List<Enemy> Enemies = new List<Enemy>();
    public static List<Enemy> HeroAtacks = new List<Enemy>();
    /*private int _heroAtacks;
    public int HeroAtacks { get { return _heroAtacks; } }*/

    public GameManager() { }

    public static async Task Turn()
    {
        for (int Turns = 1; ; Turns++)
        {
            Console.WriteLine(Turns);
            Console.WriteLine("====================");
            for (int i = 0; i < Enemies.Count; i++)
            {
                await Task.Run(() => Enemies[i].TryAction());
            }
            Console.WriteLine("====================");
            Thread.Sleep(500);
            if (HeroAtacks.Count == Enemies.Count)
            {
                Console.WriteLine("============================");
                Console.WriteLine($"Герой был убит!");
                Console.WriteLine($"Количество ходов {Turns}");
                Console.WriteLine("============================");
                break;
            }
            if(HeroAtacks.Count != Enemies.Count)
            {
                for(int i = 0; i < Enemies.Count; i++)
                {
                    HeroAtacks.Clear();
                }
            }
        }
    }
}

