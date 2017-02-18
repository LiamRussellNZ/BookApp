using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LoadPhysical_Click(object sender, EventArgs e)
        {
            PhysicalBook PB1 = new PhysicalBook("The Handmaid's Tale", "Margaret Atwood", 1985, 1.2, 311);
            PhysicalBook PB2 = new PhysicalBook("1984", "George Orwell", 1949, 1.2, 287);
            PhysicalBook PB3 = new PhysicalBook("Brave New World", "Aldous Huxley", 1932, 1.2, 311);

            lst_Books.Items.Add(PB1);
            lst_Books.Items.Add(PB2);
            lst_Books.Items.Add(PB3);
        }

        private void btn_LoadeBooks_Click(object sender, EventArgs e)
        {
            EBook EB1 = new EBook("Tom Clancy True Faith and Allegiance", "Mark Greaney", 2016, 5351, "Kindle Edition", 750);
            EBook EB2 = new EBook("Path of Destruction: Star Wars Legends (Darth Bane)", "Drew Karpyshyn", 2011, 6906, "Kindle Edition", 338);
            EBook EB3 = new EBook("Shadow Kill: A Strikeback Novel", "Chris Ryan", 2017, 1861, "Kindle Edition", 320);

            lst_Books.Items.Add(EB1);
            lst_Books.Items.Add(EB2);
            lst_Books.Items.Add(EB3);
        }

        private void btn_LoadAudioBooks_Click(object sender, EventArgs e)
        {
            AudioBook AB1 = new AudioBook("The Princess Diarist", "Carrie Fisher", 2016, 56222, 310, "Carrie Fisher, Billie Lourd");
            AudioBook AB2 = new AudioBook("Scrappy Little Nobody", "Anna Kendrick", 2016, 56222, 360, "Anna Kendrick");
            AudioBook AB3 = new AudioBook("Elon Musk", "Ashlee Vance", 2016, 56222, 803, "Fred Sanders");

            lst_Books.Items.Add(AB1);
            lst_Books.Items.Add(AB2);
            lst_Books.Items.Add(AB3);
        }
    }
}
