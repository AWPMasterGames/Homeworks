using Coldun;
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
        void z1()
        {
            List<Spell> spells = new List<Spell>();

            spells.Add(new DamageSpell("Огненая спышка", 50, "площади"));
            spells.Add(new DamageSpell("Ледяной шип", 25, "цели"));
            spells.Add(new HealSpell("Исцеление", 25, "цели"));
            spells.Add(new HealSpell("Массовое исцеление", 25, "цели"));
            spells.Add(new DamageSpell("Ментльный червь", 25, "ментали"));

            for (int i = 0; i < spells.Count; i++)
            {
                spells[i].Cast();
            }
        }

        void z2()
        {
            Random rand = new Random();
            string[] names = { "Рик и Морти", "Дарк Рп", "Путешесвтие Чибупельки", "Лучшее с T2X2", "Unity для чайников" };
            string[] authors = { "Рик Санчес", "Екатерина Гузеева", "Федорчук Паносович", "Морти Алфабетов", "Александр Серый" };

            Stack<Book> books = new Stack<Book>();
            for(int i = 0; i < rand.Next(1,10); i++)
            {
                books.Push(new Book(names[rand.Next(0, names.Length - 1)], rand.Next(2, 400), authors[rand.Next(0, authors.Length - 1)]));
            }

            for (int i = books.Count; i > 0; i--)
            {
                Console.WriteLine("============");
                books.Pop().Info();
                Console.WriteLine("============");
            }
            
        }
        void z3()
        {
            List<Car> Cars = new List<Car>();
            for (int i = 0; i < 5; i++)
            {
                Cars.Add(new Car("Арбуз", 100));
            }
            Cars.Add(new Car("буба", 333));
            Cars.Add(new Car("буба", 333));
            Cars.Add(new Car("cek", 3353));

            for (int i = 0; i < Cars.Count; i++)
            {
                if (Cars[i].GetMark() == "cek")
                {
                    Cars[i].Info();
                }
            }
        }
        z3();
    }
}

