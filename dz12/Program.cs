using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new DateTime(9999, 10, 11, 10, 0, 0));
            NotificationsManager.AddNotification(new Notification("Задание от мамы", "Покормить кошку", DateTime.Now.AddSeconds(5)));
            NotificationsManager.AddNotification(new Notification("Задание папы", "Сходить в магазин", new DateTime(2024, 10, 11, 10, 0, 0)));
            NotificationsManager.AddNotification(new Notification("Школа", "Пойти на экзамен", new DateTime(2024, 10, 16, 12, 0, 0)));
            NotificationsManager.AddNotification(new Notification("Школа", "Получить атестат", new DateTime(2024, 10, 17, 12, 0, 0)));
            NotificationsManager.AddNotification(new Notification("Школа", "Сдать учебники", new DateTime(2024, 10, 18, 12, 0, 0)));
            NotificationsManager.AddNotification(new Notification("Tiktok", "Снять видео", new DateTime(2024, 10, 15, 15, 0, 0)));
            NotificationsManager.AddNotification(new Notification("Tiktok", "Отправить другу милион тиктоков", new DateTime(2024, 10, 16, 16, 0, 0)));
            NotificationsManager.AddNotification(new Notification("Youtube", "Почилить в ютубе", new DateTime(2024, 10, 16, 18, 0, 0)));
            NotificationsManager.AddNotification(new Notification("День рождение", "Пойти на день рождение друга", new DateTime(2024, 11, 14, 10, 0, 0)));
            NotificationsManager.AddNotification(new Notification("Сон", "Пойти спать", new DateTime(2024, 10, 16, 21, 30, 0)));
            NotificationsManager.FindNotification(new DateTime(2024, 10, 17));
            for (; 0 <= NotificationsManager.NotificationsCount; )
            {
                NotificationsManager.CheckNotifications();
                if (NotificationsManager.NotificationsCount == 0) break;
            }
        }
    }
}
