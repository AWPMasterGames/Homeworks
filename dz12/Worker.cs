using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class Worker
{
    private string _name;
    private string _description;
    private int _sleepTime;
    public DateTime LanchStart;
    public DateTime LanchEnd;
    public DateTime StartWork;
    public DateTime EndWork;

    public string Name { get { return _name; } }
    public string Description { get { return _description; } }

    bool Islanch()
    {
        return DateTime.Now >= LanchStart && DateTime.Now <= LanchEnd;
    }
    bool IsEndWork()
    {

        return DateTime.Now >= EndWork;
    }

    public Worker(string name, string description, int sleeptime = 100)
    {
        _name = name;
        _description = description;
        _sleepTime = sleeptime;
        EndWork = DateTime.Now.AddYears(1);
    }
    public void ComeToWork(Brigadier brigadier)
    {
        Console.WriteLine($"{Name} прибыл на работу {DateTime.Now}");
        StartWork = DateTime.Now;
        brigadier.workers.Add(this);
    }
    public void Work()
    {
        while (true)
        {
            
            if(IsEndWork())
            {
                Console.WriteLine($"{Name} окончил работу");
                FinishWork();
                break;
            }
            if (Islanch())
            {
                Console.WriteLine($"{Name} вышел на перерыв");
                break;
            }
            Console.WriteLine($"{Name} {Description}");
            Thread.Sleep(_sleepTime);
        }
    }
    public void FinishWork()
    {
        Console.WriteLine($"{Name} сдал отчёт о работе {DateTime.Now}");
    }
}

