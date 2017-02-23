namespace BookApp_WinForms
{
    partial class frm_BookApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_Books = new System.Windows.Forms.ListBox();
            this.btn_LoadPhysical = new System.Windows.Forms.Button();
            this.btn_LoadeBooks = new System.Windows.Forms.Button();
            this.btn_LoadAudioBooks = new System.Windows.Forms.Button();
            this.lbl_BookList = new System.Windows.Forms.Label();
            this.lstView_BookDetails = new System.Windows.Forms.ListView();
            this.Grid_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grid_year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grid_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstbx_Reflect = new System.Windows.Forms.ListBox();
            this.btn_SaveText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Books
            // 
            this.lst_Books.FormattingEnabled = true;
            this.lst_Books.Location = new System.Drawing.Point(160, 43);
            this.lst_Books.Name = "lst_Books";
            this.lst_Books.Size = new System.Drawing.Size(334, 186);
            this.lst_Books.TabIndex = 0;
            this.lst_Books.SelectedIndexChanged += new System.EventHandler(this.lst_Books_SelectedIndexChanged);
            // 
            // btn_LoadPhysical
            // 
            this.btn_LoadPhysical.Location = new System.Drawing.Point(12, 43);
            this.btn_LoadPhysical.Name = "btn_LoadPhysical";
            this.btn_LoadPhysical.Size = new System.Drawing.Size(129, 23);
            this.btn_LoadPhysical.TabIndex = 1;
            this.btn_LoadPhysical.Text = "Load PhysicalBooks";
            this.btn_LoadPhysical.UseVisualStyleBackColor = true;
            this.btn_LoadPhysical.Click += new System.EventHandler(this.btn_LoadPhysical_Click);
            // 
            // btn_LoadeBooks
            // 
            this.btn_LoadeBooks.Location = new System.Drawing.Point(12, 72);
            this.btn_LoadeBooks.Name = "btn_LoadeBooks";
            this.btn_LoadeBooks.Size = new System.Drawing.Size(129, 23);
            this.btn_LoadeBooks.TabIndex = 2;
            this.btn_LoadeBooks.Text = "Load eBooks";
            this.btn_LoadeBooks.UseVisualStyleBackColor = true;
            this.btn_LoadeBooks.Click += new System.EventHandler(this.btn_LoadeBooks_Click);
            // 
            // btn_LoadAudioBooks
            // 
            this.btn_LoadAudioBooks.Location = new System.Drawing.Point(12, 101);
            this.btn_LoadAudioBooks.Name = "btn_LoadAudioBooks";
            this.btn_LoadAudioBooks.Size = new System.Drawing.Size(129, 23);
            this.btn_LoadAudioBooks.TabIndex = 3;
            this.btn_LoadAudioBooks.Text = "Load AudioBooks";
            this.btn_LoadAudioBooks.UseVisualStyleBackColor = true;
            this.btn_LoadAudioBooks.Click += new System.EventHandler(this.btn_LoadAudioBooks_Click);
            // 
            // lbl_BookList
            // 
            this.lbl_BookList.AutoSize = true;
            this.lbl_BookList.Location = new System.Drawing.Point(157, 27);
            this.lbl_BookList.Name = "lbl_BookList";
            this.lbl_BookList.Size = new System.Drawing.Size(51, 13);
            this.lbl_BookList.TabIndex = 5;
            this.lbl_BookList.Text = "Book List";
            // 
            // lstView_BookDetails
            // 
            this.lstView_BookDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Grid_year,
            this.Grid_title,
            this.Grid_author});
            this.lstView_BookDetails.FullRowSelect = true;
            this.lstView_BookDetails.GridLines = true;
            this.lstView_BookDetails.Location = new System.Drawing.Point(33, 283);
            this.lstView_BookDetails.MultiSelect = false;
            this.lstView_BookDetails.Name = "lstView_BookDetails";
            this.lstView_BookDetails.Size = new System.Drawing.Size(471, 421);
            this.lstView_BookDetails.TabIndex = 6;
            this.lstView_BookDetails.UseCompatibleStateImageBehavior = false;
            this.lstView_BookDetails.View = System.Windows.Forms.View.Details;
            // 
            // Grid_title
            // 
            this.Grid_title.DisplayIndex = 0;
            this.Grid_title.Text = "Tiitle";
            this.Grid_title.Width = 200;
            // 
            // Grid_year
            // 
            this.Grid_year.DisplayIndex = 1;
            this.Grid_year.Text = "Year";
            this.Grid_year.Width = 66;
            // 
            // Grid_author
            // 
            this.Grid_author.Text = "Author";
            // 
            // lstbx_Reflect
            // 
            this.lstbx_Reflect.FormattingEnabled = true;
            this.lstbx_Reflect.Location = new System.Drawing.Point(543, 101);
            this.lstbx_Reflect.Name = "lstbx_Reflect";
            this.lstbx_Reflect.Size = new System.Drawing.Size(301, 277);
            this.lstbx_Reflect.TabIndex = 7;
            // 
            // btn_SaveText
            // 
            this.btn_SaveText.Location = new System.Drawing.Point(12, 150);
            this.btn_SaveText.Name = "btn_SaveText";
            this.btn_SaveText.Size = new System.Drawing.Size(129, 23);
            this.btn_SaveText.TabIndex = 8;
            this.btn_SaveText.Text = "Save to text file";
            this.btn_SaveText.UseVisualStyleBackColor = true;
            this.btn_SaveText.Click += new System.EventHandler(this.btn_SaveText_Click);
            // 
            // frm_BookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 731);
            this.Controls.Add(this.btn_SaveText);
            this.Controls.Add(this.lstbx_Reflect);
            this.Controls.Add(this.lstView_BookDetails);
            this.Controls.Add(this.lbl_BookList);
            this.Controls.Add(this.btn_LoadAudioBooks);
            this.Controls.Add(this.btn_LoadeBooks);
            this.Controls.Add(this.btn_LoadPhysical);
            this.Controls.Add(this.lst_Books);
            this.Name = "frm_BookApp";
            this.Text = "BookApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Books;
        private System.Windows.Forms.Button btn_LoadPhysical;
        private System.Windows.Forms.Button btn_LoadeBooks;
        private System.Windows.Forms.Button btn_LoadAudioBooks;
        private System.Windows.Forms.Label lbl_BookList;
        private System.Windows.Forms.ListView lstView_BookDetails;
        private System.Windows.Forms.ColumnHeader Grid_title;
        private System.Windows.Forms.ColumnHeader Grid_author;
        private System.Windows.Forms.ColumnHeader Grid_year;
        private System.Windows.Forms.ListBox lstbx_Reflect;
        private System.Windows.Forms.Button btn_SaveText;
    }
}

