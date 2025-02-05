using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Storage
{
    public static List<Product> Products = new List<Product>() {
        new Product("Amayasss","Голубь жив",100,200)
    };

    public static List<Product> GetProducts()
    {
        return Products;
    }
}

