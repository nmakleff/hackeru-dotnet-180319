using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    public class BookViewer
    {
        private Book _book;

        public BookViewer(Book book)
        {
            _book = book;
        }

        private void ShowBookDetails()
        {
            Console.WriteLine("Author: " + _book.GetAuthor());
            Console.WriteLine("Name: " + _book.GetName());
            Console.WriteLine("Num of pages: " + _book.GetNumberOfPages());
            Console.WriteLine("Publishing: " + _book.GetPublishing());
            Console.WriteLine("Publishing Year: " + _book.GetPublishingYear());
        }

        private void ShowCurrentPage()
        {
            Page currentPage = _book.GetCurrentPageObject();
            if (currentPage == null)
            {
                Console.WriteLine("PAGE IS NOT SET!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            else
            {
                if (currentPage.IsChapterTitle() == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Chapter {0}: {1}", currentPage.GetChapterNumber(), currentPage.GetChapterTitle());
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(currentPage.GetContent());
                    Console.WriteLine();
                }
            }
        }

        private bool ShowMenu()
        {
            Console.WriteLine("You are currently viewing page number " + _book.GetCurrentPage());
            Console.Write("Press: 'Q' quit application, 'N' for next page, 'P' for previous page, 'F' for first page, 'L' for last page, or simply enter page number: ");
            string Cmd = Console.ReadLine();

            Cmd = Cmd.ToUpper();
            switch (Cmd)
            {
                case "N": _book.NextPage(); break;
                case "P": _book.PrevPage(); break;
                case "F": _book.GotoFirstPage(); break;
                case "L": _book.GotoLastPage(); break;
                case "Q": return true;
                default:
                    int PageNum = 0;
                    if (int.TryParse(Cmd, out PageNum) == true)
                    {
                        _book.GotoPage(PageNum);
                    }
                    break;
            }

            ShowCurrentPage();
            return false;
        }

        public void ViewBook()
        {
            ShowBookDetails();
            ShowCurrentPage();
            while (ShowMenu() == false) { }
        }

    }
}
