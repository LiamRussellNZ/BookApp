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
            this.lstView_BookDetails = new System.Windows.Forms.ListView();
            this.GridTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GridAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GridYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstbx_Reflect = new System.Windows.Forms.ListBox();
            this.btn_SaveText = new System.Windows.Forms.Button();
            this.btn_LoadBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstView_BookDetails
            // 
            this.lstView_BookDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GridTitle,
            this.GridAuthor,
            this.GridYear});
            this.lstView_BookDetails.FullRowSelect = true;
            this.lstView_BookDetails.GridLines = true;
            this.lstView_BookDetails.Location = new System.Drawing.Point(12, 43);
            this.lstView_BookDetails.MultiSelect = false;
            this.lstView_BookDetails.Name = "lstView_BookDetails";
            this.lstView_BookDetails.Size = new System.Drawing.Size(471, 421);
            this.lstView_BookDetails.TabIndex = 6;
            this.lstView_BookDetails.UseCompatibleStateImageBehavior = false;
            this.lstView_BookDetails.View = System.Windows.Forms.View.Details;
            this.lstView_BookDetails.SelectedIndexChanged += new System.EventHandler(this.lstView_BookDetails_SelectedIndexChanged);
            // 
            // GridTitle
            // 
            this.GridTitle.Text = "Title";
            this.GridTitle.Width = 250;
            // 
            // GridAuthor
            // 
            this.GridAuthor.Text = "Author";
            this.GridAuthor.Width = 100;
            // 
            // GridYear
            // 
            this.GridYear.Text = "Year";
            // 
            // lstbx_Reflect
            // 
            this.lstbx_Reflect.FormattingEnabled = true;
            this.lstbx_Reflect.Location = new System.Drawing.Point(505, 43);
            this.lstbx_Reflect.Name = "lstbx_Reflect";
            this.lstbx_Reflect.Size = new System.Drawing.Size(301, 277);
            this.lstbx_Reflect.TabIndex = 7;
            // 
            // btn_SaveText
            // 
            this.btn_SaveText.Location = new System.Drawing.Point(12, 483);
            this.btn_SaveText.Name = "btn_SaveText";
            this.btn_SaveText.Size = new System.Drawing.Size(129, 23);
            this.btn_SaveText.TabIndex = 8;
            this.btn_SaveText.Text = "Save to text file";
            this.btn_SaveText.UseVisualStyleBackColor = true;
            this.btn_SaveText.Click += new System.EventHandler(this.btn_SaveText_Click);
            // 
            // btn_LoadBooks
            // 
            this.btn_LoadBooks.Location = new System.Drawing.Point(12, 512);
            this.btn_LoadBooks.Name = "btn_LoadBooks";
            this.btn_LoadBooks.Size = new System.Drawing.Size(129, 23);
            this.btn_LoadBooks.TabIndex = 9;
            this.btn_LoadBooks.Text = "Load Books";
            this.btn_LoadBooks.UseVisualStyleBackColor = true;
            this.btn_LoadBooks.Click += new System.EventHandler(this.btn_LoadBooks_Click);
            // 
            // frm_BookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 581);
            this.Controls.Add(this.btn_LoadBooks);
            this.Controls.Add(this.btn_SaveText);
            this.Controls.Add(this.lstbx_Reflect);
            this.Controls.Add(this.lstView_BookDetails);
            this.Name = "frm_BookApp";
            this.Text = "BookApp";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstView_BookDetails;
        private System.Windows.Forms.ListBox lstbx_Reflect;
        private System.Windows.Forms.Button btn_SaveText;
        private System.Windows.Forms.Button btn_LoadBooks;
        private System.Windows.Forms.ColumnHeader GridTitle;
        private System.Windows.Forms.ColumnHeader GridAuthor;
        private System.Windows.Forms.ColumnHeader GridYear;
    }
}

