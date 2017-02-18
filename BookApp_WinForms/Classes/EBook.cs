using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_WinForms
{
    class EBook:DigitalBook,IPageCount
    {
        //fields
        private string fileformat;

        //property
        public string FileFormat
        {
            get { return fileformat; }
            set {  fileformat = value;}
        }

        //constructor
        public EBook() { }

        public EBook(string title, string author, int year, int filesize, string fileformat, int pagecount)
        {
            Title = title;
            Author = author;
            Year = year;
            FileSize = filesize;
            FileFormat = fileformat;
            PageCount = pagecount;
        }

        //Methods
        public override string ToString()
        {
            return Title.ToString() + ": e-Book";
        }
    }
}
