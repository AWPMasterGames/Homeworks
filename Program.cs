using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class TaskStarter
{
    private void Print()
    {
        Console.WriteLine("эражан");
    }
    public async Task PrintAsync()
    {
        await Task.Run(() => Print());
    }
}

namespace Potoki2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            GameManager.Enemies.Add(new Enemy("Zombie"));
            GameManager.Enemies.Add(new Enemy("Skeleton"));
            /*GameManager.Enemies.Add(new Enemy("Goblin"));
            GameManager.Enemies.Add(new Enemy("Slime"));*/

            await GameManager.Turn();
        }
    }
}
