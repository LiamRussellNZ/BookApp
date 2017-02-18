using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp_WinForms
{
    class AudioBook:DigitalBook
    {
        //fields
        private int length;
        private string narrator;

        //property
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public string Narrator
        {
            get{ return narrator; }
            set{ narrator = value; }
        }

        //constructor
        public AudioBook(string title,string author,int year,int filesize,int length,string narrator)
        {
            Title = title;
            Author = author;
            Year = year;
            FileSize = filesize;
            Length = length;
            Narrator = narrator;
        }

        //method
        public override string ToString()
        {
            return Title.ToString()+": AudioBook";
        }
    }
}
