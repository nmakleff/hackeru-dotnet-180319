using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    class LibraryBookRecord
    {
        private bool _isBorrowed;
        private string _customerName;
        private Book _book;

        public LibraryBookRecord(Book book)
        {
            _book = book;
            _isBorrowed = false;
        }

        public void SetBookAsBorrowed(string customerName)
        {
            _isBorrowed = true;
            _customerName = customerName;
        }

        public void SetBookAsReturned()
        {
            _isBorrowed = false;
            _customerName = "";
        }

        public bool IsBorrowed()
        {
            return _isBorrowed;
        }

        public string GetCustomerName()
        {
            return _customerName;
        }

        public Book GetBook()
        {
            return _book;
        }

    }
}
