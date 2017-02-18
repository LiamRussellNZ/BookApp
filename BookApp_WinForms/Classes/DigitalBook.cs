using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_WinForms
{
    abstract class DigitalBook : Book,IPageCount
    {
        //Field
        private int filesize;

        //Property
        public int FileSize
        {
            get {return filesize;}
            set{ filesize = value; }
        }

        //IPageCount implementaion
        public int PageCount { get; set; }

        //Constructor
        public DigitalBook() { }

        //Mehtods
    }
}
