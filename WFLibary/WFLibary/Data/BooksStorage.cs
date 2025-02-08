using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;


static class BooksStorage
{
    public static List<Book> Books;

    public static List<Book> GetBooksOfStorage()
    {
        if (Books == null)
        {
            Books = new List<Book>();
            Books.Add(new Book(new Font("Microsoft Sans Serif",10),"Black",1, "Лень делать что-то", "Тимон","Мне лень что-либо деать"));
            Books.Add(new Book(new Font("Microsoft Sans Serif",10),"Orange", 2, "Лень делать что-то 2", "Тимон","Сделайт за меня"));
        }
        return Books;
    }
    public static void AddBookToStorage(Book book, ListBox listBox)
    {
        Books.Add(book);
        listBox.Items.Add(book);
    }
    public static void RemoveBookToStorage(Book book, ListBox listBox)
    {
        Books.Remove(book);
        listBox.Items.Remove(book);
    }
    public static void EditBookToStorage(Book book, ListBox listBox)
    {
        Books.Remove(book);
        listBox.Items.Remove(book);
        Books.Add(book);
        listBox.Items.Add(book);
    }
}

