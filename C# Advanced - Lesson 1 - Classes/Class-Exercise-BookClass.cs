using System;

public class Book
{
    private string _bookName;
    private string _author;
    private string _publishing;
    private int _numberOfPages;
    private int _publishingDate;

    public Book(string bookName, string author, string publishing, int numberOfPages, int publishingDate)
    {
        _bookName = bookName;
        _author = author;
        _publishing = publishing;
        _numberOfPages = numberOfPages;
        _publishingDate = publishingDate;
    }

    public void PrintBookDetails()
    {
        Console.WriteLine("Book name: " + _bookName);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Publishing: " + _publishing);
        Console.WriteLine("Pages: " + _numberOfPages);
        Console.WriteLine("Publishing year: " + _publishingDate);
    }

    public void Read()
    {
        Console.WriteLine("Read {0} pages", _numberOfPages);
    }

}


public class Program
{
    public static void Main()
    {
        Book newBook = new Book("A great book", "A great author", "A great publishing house", 100, 2010);

        newBook.PrintBookDetails();
        newBook.Read();
    }
}
