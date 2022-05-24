using System;
using System.Collections.Generic;

Book LOTR1 = new Book("Fellowship Of The Ring", "J.R.R. Tolkien", new DateTime(1954, 7, 23));
Book LOTR2 = new Book("The Two Towers", "J.R.R. Tolkien", new DateTime(1954, 11, 11));
Book LOTR3 = new Book("The Return Of The King", "J.R.R. Tolkien", new DateTime(1955, 10, 20));

var books = new List<Book>();
books.Add(LOTR1);
books.Add(LOTR2);
books.Add(LOTR3);



foreach (Book book in books)
{
    Console.WriteLine($"{book}");
};






class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime Date { get; set; }

    public Book(string title, string author, DateTime date)
    {
        Title = title;
        Author = author;
        Date = date;
    }

    public override string ToString()
    {
        return String.Format($"Title : {Title} Author : {Author} Published : {Date.Year}");
    }
}