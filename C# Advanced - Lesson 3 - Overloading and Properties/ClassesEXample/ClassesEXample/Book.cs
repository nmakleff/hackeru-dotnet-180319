using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    public class Book
    {

        private string _author;
        private string _name;
        private string _publishing;
        private int _numOfPages;
        private int _publishingYear;
        private int _currentPage;

        private Page[] _pages;

        public Book(string author, string name, string publishing, int numOfPages, int publishingYear)
        {
            _author = author;
            _name = name;
            _publishing = publishing;
            _numOfPages = numOfPages;
            _publishingYear = publishingYear;
            _currentPage = 1;
            _pages = new Page[numOfPages];
        }

        public string GetAuthor()
        {
            return _author;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetPublishing()
        {
            return _publishing;
        }

        public int GetPublishingYear()
        {
            return _publishingYear;
        }

        public int GetNumberOfPages()
        {
            return _numOfPages;
        }

        public void SetPage(Page page)
        {
            if (page.GetPageNumber() >= 1 && page.GetPageNumber() <= _numOfPages)
            {
                _pages[page.GetPageNumber() - 1] = page;
            }
        }

       
        // return the current page the viewer is seeing
        public int GetCurrentPage()
        {
            return _currentPage;
        }

        // sets the current page the user sees
        public void GotoPage(int pageNumber)
        {
            if (pageNumber >= 1 && pageNumber <= _numOfPages)
            {
                _currentPage = pageNumber;
            }
        }

        // goto the first page
        public void GotoFirstPage()
        {
            GotoPage(1);
        }

        // goto the last page
        public void GotoLastPage()
        {
            GotoPage(_numOfPages);
        }

        // goto next page
        public void NextPage()
        {
            GotoPage(_currentPage + 1);
        }

        // goto prev page
        public void PrevPage()
        {
            GotoPage(_currentPage - 1);
        }

        // gets the current page's content
        public Page GetCurrentPageObject()
        {
            return _pages[_currentPage - 1];
        }
    }

}
