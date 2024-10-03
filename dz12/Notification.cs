using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Notification
{
    private DateTime _dateSend;
    private string _title;
    private string _description;

    public DateTime DateSend { get { return _dateSend; } }
    public string Title { get { return _title; } }
    public string Description { get { return _description; } }

    public Notification(string title, string description, DateTime date)
    {
        _dateSend = date;
        _title = title;
        _description = description;
    }
    public bool Send()
    {
        if (DateSend < DateTime.Now)
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"{Title}\n{Description}");
            Console.WriteLine("=====================");
            return true;
        }
        return false;
    }
}

