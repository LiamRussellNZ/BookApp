using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_WinForms
{
    class PhysicalBook : Book,IPageCount
    {
        //Fields
        private double weight;

        //Properties

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //IPageCount implementaion
        public int PageCount { get; set; }

        //Constructor

        public PhysicalBook() { }

        public PhysicalBook(string title, string author, int year, double weight,int pagecount)
        {
            Title = title;
            Author = author;
            Year = year;
            Weight = weight;
            PageCount = pagecount;
        }

        //Methods
        public override string ToString()
        {
            return Title.ToString() + ": Physcial Book";
        }
    }
}
