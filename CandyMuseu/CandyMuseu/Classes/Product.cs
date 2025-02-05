using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    public string Name { get; set; }
    public string Producer { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }

    public Product(string name, string producer, decimal price,int count)
    {
        Name = name;
        Producer = producer;
        Price = price;
        Count = count;
    }
    public Product() { }
    public override string ToString()
    {
        return $"{Name} Производитель: {Producer}, Цена {Price}руб. - {Count} шт";
    }
}

