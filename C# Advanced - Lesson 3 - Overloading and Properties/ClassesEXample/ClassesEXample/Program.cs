using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book("Nir", "My new book", "HackerU publishing", 10, 2019);

            //book.SetPage(new Page(1, "A new beginning", 1));
            //for (int i = 2; i <= 10; i++)
            //{
            //    book.SetPage(new Page(i, "This is the content of page number " + i));
            //}

            //BookViewer bookViewer = new BookViewer(book);
            //bookViewer.ViewBook();


            Library library = new Library(100);
            for (int i = 0; i < 10; i++)
            {
                library.AddBookToLibrary(new Book("Author" + i, "Book" + i, "HackerU publishing", 100, 2019));
            }

            library.BarrowBookByBookName("Book0", "Nir");
            library.BarrowBookByAuthorName("Author3", "Nir");
            library.PrintBorrowedBooks();
            Console.WriteLine("Now, lets return one book");
            library.ReturnBook("Book0", "Nir");
            library.PrintBorrowedBooks();

            //PropertiesExample PE = new PropertiesExample(2);
            //PE.Month = 1;
            //Console.WriteLine(PE.Month);
            //PE.Month = 13;
            //Console.WriteLine(PE.Month);


            //OverloadingExample OE = new OverloadingExample(1, 3);
        }
    }
}
