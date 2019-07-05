using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    class Library
    {
        private int _capacity;
        private int _bookCount;
        private LibraryBookRecord[] _books;

        public Library(int capacity)
        {
            _capacity = capacity;
            _bookCount = 0;
            _books = new LibraryBookRecord[_capacity];
        }

        public void AddBookToLibrary(Book newBook)
        {
            if (_bookCount < _capacity)
            {
                _books[_bookCount] = new LibraryBookRecord(newBook);
                _bookCount++;
            }
        }

        public Book BarrowBookByBookName(string bookName, string customerName)
        {
            for (int i = 0; i < _bookCount; i++)
            {
                if (_books[i] != null)
                {
                    if (_books[i].GetBook().GetName().ToLower() == bookName.ToLower() && _books[i].IsBorrowed() == false)
                    {
                        _books[i].SetBookAsBorrowed(customerName);
                        return _books[i].GetBook();
                    }
                }
            }

            return null;
        }

        public Book BarrowBookByAuthorName(string authorName, string customerName)
        {
            for (int i = 0; i < _bookCount; i++)
            {
                if (_books[i] != null)
                {
                    if (_books[i].GetBook().GetAuthor().ToLower() == authorName.ToLower() && _books[i].IsBorrowed() == false)
                    {
                        _books[i].SetBookAsBorrowed(customerName);
                        return _books[i].GetBook();
                    }
                }
            }

            return null;
        }

        public void ReturnBook(string bookName, string customerName)
        {
            for (int i = 0; i < _bookCount; i++)
            {
                if (_books[i] != null)
                {
                    if (_books[i].GetBook().GetName().ToLower() == bookName.ToLower() && _books[i].IsBorrowed() == true)
                    {
                        _books[i].SetBookAsReturned();
                        break;
                    }
                }
            }
        }

        public void PrintBorrowedBooks()
        {
            for (int i = 0; i < _bookCount; i++)
            {
                if (_books[i].IsBorrowed() == true)
                {
                    Console.WriteLine("Book {0} is borrowed by {1}", _books[i].GetBook().GetName(), _books[i].GetCustomerName());
                }
            }
        }
    }
}
