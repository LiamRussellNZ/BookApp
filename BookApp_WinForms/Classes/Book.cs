using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_WinForms
{
    abstract class Book
    {
        //Fields
        private string title;
        private string author;
        private int year;

        //Properties
        public string Title
        {
            get { return title;  }
            set { title = value;  }
        }

        public string Author
        {
            get { return author;}
            set { author = value; }
        }

        public int Year
        {
            get { return year;}
            set { year = value; }
        }

        //Constructors
        public Book() { }

        //Methods
        public override string ToString()
        {
            return Title.ToString();
        }
    }
}
