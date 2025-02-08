using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    public Font font;
    public string TextColor;
    public int BookId;
    public string Title;
    public string Author;
    public string Text;

    public Book(Font font,string textcolor, int bookId, string title, string author, string text)
    {
        this.font = font;
        this.TextColor = textcolor;
        this.BookId = bookId;
        this.Title = title;
        this.Author = author;
        this.Text = text;
    }

    public override string ToString()
    {
        return $"Название:  {Title}, Автор:  {Author}";
    }
    public string ToSaveBook()
    {
        return $"{font.Name};{font.Size};{TextColor};{Title};{Author};{Text}";
    }
}

