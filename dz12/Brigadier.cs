using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


class Brigadier
{
    public List<Worker> workers = new List<Worker>();

    static ThreadStart WorkTime = null;
    //Brigadier() { }

    public void Work()
    {

        for (int i = 0; i < workers.Count; i++)
        {
            Thread work = new Thread(workers[i].Work);
            work.Start();
        }

    }
    public void Lanch(DateTime lanch)
    {
        for (int i = 0; i < workers.Count; i++)
        {
            workers[i].LanchStart = DateTime.Now;
            workers[i].LanchEnd = lanch;
        }
        if (DateTime.Now >= lanch) Console.WriteLine($"Перерыв в {lanch}"); ;
        for (; DateTime.Now <= lanch;) { }
    }
    public void FinishWork(DateTime date)
    {
        for (int i = 0; i < workers.Count; i++)
        {
            workers[i].EndWork = date;
        }
    }
    public void FinishWork()
    {
        /*for (int i = 0; i < workers.Count; i++)
        {
            workers[i-j].EndWork = DateTime.Now;
        }*/
        for (; ; )
        {
            if(workers.Count <=0) break;
            workers[0].EndWork = DateTime.Now;
            workers.RemoveAt(0);
        }
    }

}

