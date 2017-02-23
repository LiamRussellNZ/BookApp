using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace BookApp_WinForms
{
    public partial class frm_BookApp : Form
    {
        public frm_BookApp()
        {
            InitializeComponent();
        }

        List<Book> bookList = new List<Book>();
        List<string> bookProp = new List<string>();

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

            ListViewItem item1 = new ListViewItem(AB1.Year.ToString());
            item1.SubItems.Add(AB1.Title);
            item1.SubItems.Add(AB1.Author);

            ListViewItem item2 = new ListViewItem(AB2.Year.ToString());
            item2.SubItems.Add(AB2.Title);
            item2.SubItems.Add(AB2.Author);

            ListViewItem item3 = new ListViewItem(AB3.Year.ToString());
            item3.SubItems.Add(AB3.Title);
            item3.SubItems.Add(AB3.Author);

            lstView_BookDetails.Items.Add(item1);
            lstView_BookDetails.Items.Add(item2);
            lstView_BookDetails.Items.Add(item3);

            bookList.Add(AB1);
            bookList.Add(AB2);
            bookList.Add(AB3);

            GetBooks(bookList);
        }

        private void lst_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbx_Reflect.Items.Clear(); 
            Book sel = lst_Books.SelectedItems[0] as Book;

            if (sel is PhysicalBook)
            {
                try
                {
                    PhysicalBook pbk = (PhysicalBook)sel;
                    GetProps(pbk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong", "Error");
                }
            }
            else if (sel is EBook)
            {
                try
                {
                    EBook ebk = (EBook)sel;
                    GetProps(ebk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong", "Error");
                }
            }
            else if (sel is AudioBook)
            {
                try
                {
                    AudioBook abk = (AudioBook)sel;
                    GetProps(abk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong", "Error");
                }
            }
        }

        public void GetProps(Book bk)
        {
            //reflection
            //GetProperties method returns array
            PropertyInfo[] bkInfo = bk.GetType().GetProperties();
            foreach (PropertyInfo propertyinfo in bkInfo)
            {
                var name = propertyinfo.Name;
                var value = propertyinfo.GetValue(bk);
                //lstbx_Reflect.Items.Add(name+": "+value);
            }
        }

        public void GetBooks(List<Book> bkList)
        {
            //this method uses reflection
            //GetProperties method returns array
            //foreach loop iterates over the book items in the list
            foreach (var book in bkList)
            {
                PropertyInfo[] bkInfo = book.GetType().GetProperties();
                foreach (PropertyInfo propertyinfo in bkInfo)
                {
                    var name = propertyinfo.Name;
                    var value = propertyinfo.GetValue(book);
                    bookProp.Add(name + ": " + value);
                }
            }
        }

        private void btn_SaveText_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookProp.Count!=0)
                {
                    StreamWriter myWriter = new StreamWriter("Book.txt", false);


                    GetBooks(bookList);
                    foreach (var item in bookProp)
                    {
                        myWriter.WriteLine(item);
                    }
                    myWriter.Close();
                }
                else
                {
                    MessageBox.Show("Please add some books", "Error");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when trying to save out to file");
            }
        }
    }
}
