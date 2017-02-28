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

        private void lst_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                lstbx_Reflect.Items.Add(name+": "+value);
            }
        }

        public List<string> LoopProp(Book item)
        {
            List<string> prop = new List<string>();
            try
            {
                //get properties for each book in the passed bkList
                PropertyInfo[] bkInfo = item.GetType().GetProperties();
                foreach (PropertyInfo propertyinfo in bkInfo)
                {
                    
                    var name = propertyinfo.Name;
                    var value = propertyinfo.GetValue(item);
                    prop.Add(name + ": " + value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in the LoopProp method");
            }
            return prop;
        }

        public void SaveText(List<Book> bkList)
        {
            //Declare and initilise a streamwriter object
            StreamWriter myWriter = new StreamWriter("Book.txt", false);

            //foreach loop iterates over the book items in the list passed to the method
            foreach (var book in bkList)
            {
                //get the properties for each book store the result in generic
                var list = LoopProp(book);
                if (book is AudioBook)
                {
                    //myWriter.Write("AudioBook, ");
                    AudioBook abk = (AudioBook)book;
                    myWriter.WriteLine("AudioBook," + abk.Title + "," + abk.Author + "," + abk.Year + "," + abk.FileSize + "," + abk.Length + "," + abk.Narrator);
                    //foreach (var item in list)
                    //{
                    //    myWriter.Write(item.ToString() + ", ");
                    //}
                }
                else if (book is PhysicalBook)
                {

                }

            }
            //Close the streamwriter object
            myWriter.Close();
        }

        private void btn_SaveText_Click(object sender, EventArgs e)
        {
            try
            {
                SaveText(bookList);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong when trying to save out to file");
            }
        }

        private void LoadText()
        {
            //Declare and intilise streamreader object using boot.text file 
            StreamReader bookFileReader = new StreamReader("Book.txt");

            //while the file contains line of text execute this code block
            while (!bookFileReader.EndOfStream)
            {
                //declare new string set it to equal line from textfile
                string temp = bookFileReader.ReadLine();
                //declare string array and split the above string on the "," charecter
                string[] n = temp.Split(',');
                /*depending object type the execute appropriate if statment
                 create object using parameterised constructor
                 add object to bookList*/
                if (n[0] == "AudioBook")
                {
                    AudioBook a = new AudioBook(n[1],n[2],int.Parse(n[3]),int.Parse(n[4]),int.Parse(n[5]),n[6]);
                    bookList.Add(a);
                }
                else if (n[0] == "EBook")
                {
                    EBook e = new EBook(n[1], n[2], int.Parse(n[3]), int.Parse(n[4]), n[5], int.Parse(n[6]));
                    bookList.Add(e);
                }
                else if (n[0] == "PhysicalBook")
                {
                    PhysicalBook p = new PhysicalBook(n[1], n[2], int.Parse(n[3]), double.Parse(n[4]), int.Parse(n[5]));
                    bookList.Add(p);
                }
            }
            foreach (var book in bookList)
            {
                //ListViewItems Tag field stores a reference to the book obj
                ListViewItem item = new ListViewItem(book.Title) { Tag = book };
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.Year.ToString());

                lstView_BookDetails.Items.Add(item);
            }
        }


        private void btn_LoadBooks_Click(object sender, EventArgs e)
        {
            LoadText();
        }

        private void lstView_BookDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView_BookDetails.SelectedItems.Count != 0)
            {
                lstbx_Reflect.Items.Clear();
                var sel = lstView_BookDetails.SelectedItems[0].Tag as Book;


                if (sel is PhysicalBook)
                {
                    try
                    {
                        PhysicalBook pbk = (PhysicalBook)sel;
                        var bookprop = LoopProp(sel);
                        foreach (var item in bookprop)
                        {
                            lstbx_Reflect.Items.Add(item.ToString());
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong", "Error");
                    }
                }
                //else if (sel is EBook)
                //{
                //    try
                //    {
                //        EBook ebk = (EBook)sel;
                //        GetProps(ebk);
                //    }
                //    catch (Exception)
                //    {
                //        MessageBox.Show("Something went wrong", "Error");
                //    }
                //}
                //else if (sel is AudioBook)
                //{
                //    try
                //    {
                //        AudioBook abk = (AudioBook)sel;
                //        GetProps(abk);
                //    }
                //    catch (Exception)
                //    {
                //        MessageBox.Show("Something went wrong", "Error");
                //    }
                //} 
            }
        }
    }
}
