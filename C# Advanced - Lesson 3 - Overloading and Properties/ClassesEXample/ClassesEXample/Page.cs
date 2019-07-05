using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEXample
{
    public class Page
    {
        private int _pageNumber;
        private string _pageContent;
        private bool _isChapterTitle;
        private string _chapterTitle;
        private int _chapterNumber;

        public Page(int pageNumber, string pageContent)
        {
            _pageNumber = pageNumber;
            _pageContent = pageContent;
            _isChapterTitle = false;
            _chapterTitle = string.Empty;
            _chapterNumber = 0;
        }

        public Page(int pageNumber, string chapterTitle, int chapterNumber)
        {
            _pageNumber = pageNumber;
            _pageContent = string.Empty;
            _isChapterTitle = true;
            _chapterTitle = chapterTitle;
            _chapterNumber = chapterNumber;
        }

        public int GetPageNumber()
        {
            return _pageNumber;
        }

        public string GetContent()
        {
            return _pageContent;
        }

        public bool IsChapterTitle()
        {
            return _isChapterTitle;
        }

        public string GetChapterTitle()
        {
            return _chapterTitle;
        }

        public int GetChapterNumber()
        {
            return _chapterNumber;
        }
    }
}
