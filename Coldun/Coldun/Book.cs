using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Book
{
    string Name;
    int PageCount;
    string Author;
    public Book()
    {
        Name = "Пельмешка";
        PageCount = 999;
        Author = "Агузок огурчевик";
    }
    public Book(string name)
    {
        Name = name;
        PageCount = PageCount = 999; ;
        Author = "Агузок огурчевик";
    }
    public Book(string name, int pageCount)
    {
        Name = name;
        PageCount = pageCount;
        Author = "Агузок огурчевик";
    }
    public Book(string name, int pageCount,string author)
    {
        Name = name;
        PageCount = pageCount;
        Author = author;
    }
    public void Info()
    {
        Console.WriteLine($"Название: {Name}\nАвтор: {Author}\nКоличество страниц: {PageCount}");
    }
}

