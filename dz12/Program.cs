using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace mnogopotok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Brigadier brigadier = new Brigadier();
            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Петрович", "Загрузил/Выгрузил кирпичи"));
            workers.Add(new Worker("Иваныч", "Переносит груз на кране",500));
            workers.Add(new Worker("Юр. Иваныч", "Замешал бетон", 500));
            workers.Add(new Worker("Сергей", "Кладёт кирпичь"));
            workers.Add(new Worker("Саня", "Заливает опалубку"));
            for (int i = 0; i < workers.Count; i++)
            {
                workers[i].ComeToWork(brigadier);
            }
            //brigadier.FinishWork(DateTime.Now.AddSeconds(15));
            Console.WriteLine();
            brigadier.Work();
            Thread.Sleep(2500);
            brigadier.Lanch(DateTime.Now.AddSeconds(5));
            brigadier.Work();
            Thread.Sleep(2500);
            brigadier.FinishWork();
        }
    }
}
