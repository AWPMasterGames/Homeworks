using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NotificationsManager
{
    private static List<Notification> _notifications = new List<Notification>();
    public static int NotificationsCount { get { return _notifications.Count; } }

    public static void AddNotification(Notification notification)
    {
        _notifications.Add(notification);
    }
    public static void RemoveNotification(Notification notification)
    {
        _notifications.Remove(notification);
    }
    public static void ClearNotifications()
    {
        _notifications.Clear();
    }
    public static void CheckNotifications()
    {
        for (int i = 0; i < _notifications.Count; i++)
        {
            if (_notifications[i].Send())
            {
                RemoveNotification(_notifications[i]);
                i--;
            }
            if (0 <= _notifications.Count) break;
        }
    }
    public static void FindNotification(DateTime date)
    {
        for (int i = 0; i < _notifications.Count; i++)
        {
            if (_notifications[i].DateSend.Year == date.Year && _notifications[i].DateSend.Month == date.Month && _notifications[i].DateSend.Day == date.Day)
            {
                Console.WriteLine($"{_notifications[i].DateSend.Hour}:{_notifications[i].DateSend.Minute} {_notifications[i].Title} {_notifications[i].Description}");
            }
        }
    }
    public static void FindNotification(string date)
    {
        string[] items = date.Split(' ');
        DateTime dateTime = new DateTime(int.Parse(items[0]), int.Parse(items[1]), int.Parse(items[2]));
        FindNotification(dateTime);
    }
    public static void FindNotification()
    {
        FindNotification(Console.ReadLine());
    }
}

