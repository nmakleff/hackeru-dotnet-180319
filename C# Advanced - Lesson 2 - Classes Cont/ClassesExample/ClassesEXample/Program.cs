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
            Book book = new Book("Nir", "My new book", "HackerU publishing", 10, 2019);

            book.SetPage(new Page(1, "", true, "A new beginning", 1));
            for (int i = 2; i <= 10; i++)
            {
                book.SetPage(new Page(i, "This is the content of page number " + i, false, "", 1));
            }

            BookViewer bookViewer = new BookViewer(book);
            bookViewer.ViewBook();
        }
    }
}
