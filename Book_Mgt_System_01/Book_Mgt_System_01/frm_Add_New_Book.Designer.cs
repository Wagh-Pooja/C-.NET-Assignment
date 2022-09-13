namespace Book_Mgt_System_01
{
    partial class frm_Add_New_Book
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
            this.btn_View_All_Books = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Book_Price = new System.Windows.Forms.TextBox();
            this.tb_Publication = new System.Windows.Forms.TextBox();
            this.tb_Book_ID = new System.Windows.Forms.TextBox();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.lbl_Publication = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lbl_Book_ID = new System.Windows.Forms.Label();
            this.lbl_Add_Book = new System.Windows.Forms.Label();
            this.tb_Book_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_View_All_Books
            // 
            this.btn_View_All_Books.BackColor = System.Drawing.Color.Red;
            this.btn_View_All_Books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_View_All_Books.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Books.Location = new System.Drawing.Point(368, 321);
            this.btn_View_All_Books.Name = "btn_View_All_Books";
            this.btn_View_All_Books.Size = new System.Drawing.Size(234, 41);
            this.btn_View_All_Books.TabIndex = 6;
            this.btn_View_All_Books.Text = "View All Books";
            this.btn_View_All_Books.UseVisualStyleBackColor = false;
            this.btn_View_All_Books.Click += new System.EventHandler(this.btn_View_All_Books_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(86, 321);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(93, 41);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Book_Price
            // 
            this.tb_Book_Price.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Price.Location = new System.Drawing.Point(411, 239);
            this.tb_Book_Price.MaxLength = 5;
            this.tb_Book_Price.Name = "tb_Book_Price";
            this.tb_Book_Price.Size = new System.Drawing.Size(174, 28);
            this.tb_Book_Price.TabIndex = 4;
            this.tb_Book_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Is_Price);
            // 
            // tb_Publication
            // 
            this.tb_Publication.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Publication.Location = new System.Drawing.Point(411, 187);
            this.tb_Publication.MaxLength = 25;
            this.tb_Publication.Name = "tb_Publication";
            this.tb_Publication.Size = new System.Drawing.Size(174, 28);
            this.tb_Publication.TabIndex = 3;
            this.tb_Publication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alpha_Numeric);
            // 
            // tb_Book_ID
            // 
            this.tb_Book_ID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_ID.Location = new System.Drawing.Point(411, 89);
            this.tb_Book_ID.MaxLength = 4;
            this.tb_Book_ID.Name = "tb_Book_ID";
            this.tb_Book_ID.Size = new System.Drawing.Size(174, 28);
            this.tb_Book_ID.TabIndex = 1;
            this.tb_Book_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.AutoSize = true;
            this.lbl_Book_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_Price.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Book_Price.Location = new System.Drawing.Point(42, 251);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(137, 29);
            this.lbl_Book_Price.TabIndex = 15;
            this.lbl_Book_Price.Text = "Book Price";
            this.lbl_Book_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Publication
            // 
            this.lbl_Publication.AutoSize = true;
            this.lbl_Publication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Publication.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Publication.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Publication.Location = new System.Drawing.Point(42, 197);
            this.lbl_Publication.Name = "lbl_Publication";
            this.lbl_Publication.Size = new System.Drawing.Size(143, 29);
            this.lbl_Publication.TabIndex = 12;
            this.lbl_Publication.Text = "Publication";
            this.lbl_Publication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Book_Name.Location = new System.Drawing.Point(43, 141);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(142, 29);
            this.lbl_Book_Name.TabIndex = 10;
            this.lbl_Book_Name.Text = "Book Name";
            this.lbl_Book_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Book_ID
            // 
            this.lbl_Book_ID.AutoSize = true;
            this.lbl_Book_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_ID.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_ID.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Book_ID.Location = new System.Drawing.Point(43, 89);
            this.lbl_Book_ID.Name = "lbl_Book_ID";
            this.lbl_Book_ID.Size = new System.Drawing.Size(109, 29);
            this.lbl_Book_ID.TabIndex = 9;
            this.lbl_Book_ID.Text = "Book ID";
            this.lbl_Book_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Add_Book
            // 
            this.lbl_Add_Book.AutoSize = true;
            this.lbl_Add_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Add_Book.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Book.Location = new System.Drawing.Point(211, 9);
            this.lbl_Add_Book.Name = "lbl_Add_Book";
            this.lbl_Add_Book.Size = new System.Drawing.Size(169, 40);
            this.lbl_Add_Book.TabIndex = 7;
            this.lbl_Add_Book.Text = "Add Book";
            // 
            // tb_Book_Name
            // 
            this.tb_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Book_Name.Location = new System.Drawing.Point(411, 142);
            this.tb_Book_Name.MaxLength = 20;
            this.tb_Book_Name.Name = "tb_Book_Name";
            this.tb_Book_Name.Size = new System.Drawing.Size(174, 30);
            this.tb_Book_Name.TabIndex = 2;
            this.tb_Book_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // frm_Add_New_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 408);
            this.Controls.Add(this.tb_Book_Name);
            this.Controls.Add(this.btn_View_All_Books);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Book_Price);
            this.Controls.Add(this.tb_Publication);
            this.Controls.Add(this.tb_Book_ID);
            this.Controls.Add(this.lbl_Book_Price);
            this.Controls.Add(this.lbl_Publication);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_Book_ID);
            this.Controls.Add(this.lbl_Add_Book);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Book";
            this.Load += new System.EventHandler(this.frm_Add_New_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_View_All_Books;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Book_Price;
        private System.Windows.Forms.TextBox tb_Publication;
        private System.Windows.Forms.TextBox tb_Book_ID;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.Label lbl_Publication;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lbl_Book_ID;
        private System.Windows.Forms.Label lbl_Add_Book;
        private System.Windows.Forms.TextBox tb_Book_Name;
    }
}