namespace BookApp_WinForms
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // lst_Books
            // 
            this.lst_Books.FormattingEnabled = true;
            this.lst_Books.Location = new System.Drawing.Point(160, 43);
            this.lst_Books.Name = "lst_Books";
            this.lst_Books.Size = new System.Drawing.Size(334, 186);
            this.lst_Books.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 310);
            this.Controls.Add(this.btn_LoadAudioBooks);
            this.Controls.Add(this.btn_LoadeBooks);
            this.Controls.Add(this.btn_LoadPhysical);
            this.Controls.Add(this.lst_Books);
            this.Name = "Form1";
            this.Text = "BookApp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Books;
        private System.Windows.Forms.Button btn_LoadPhysical;
        private System.Windows.Forms.Button btn_LoadeBooks;
        private System.Windows.Forms.Button btn_LoadAudioBooks;
    }
}

