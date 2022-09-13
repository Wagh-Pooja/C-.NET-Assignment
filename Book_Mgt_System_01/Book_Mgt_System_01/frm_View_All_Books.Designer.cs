namespace Book_Mgt_System_01
{
    partial class frm_View_All_Books
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dgv_Books_Details = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_Mgt_System_01DataSet = new Book_Mgt_System_01.Book_Mgt_System_01DataSet();
            this.booksDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_DetailsTableAdapter = new Book_Mgt_System_01.Book_Mgt_System_01DataSetTableAdapters.Book_DetailsTableAdapter();
            this.btn_Add_New_Book = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Mgt_System_01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Red;
            this.lbl_Header.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(224, 21);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(251, 40);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "View All Books";
            // 
            // dgv_Books_Details
            // 
            this.dgv_Books_Details.AllowUserToAddRows = false;
            this.dgv_Books_Details.AllowUserToDeleteRows = false;
            this.dgv_Books_Details.AutoGenerateColumns = false;
            this.dgv_Books_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Books_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Books_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publicationDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn});
            this.dgv_Books_Details.DataSource = this.bookDetailsBindingSource;
            this.dgv_Books_Details.Location = new System.Drawing.Point(50, 78);
            this.dgv_Books_Details.Name = "dgv_Books_Details";
            this.dgv_Books_Details.ReadOnly = true;
            this.dgv_Books_Details.Size = new System.Drawing.Size(612, 227);
            this.dgv_Books_Details.TabIndex = 2;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicationDataGridViewTextBoxColumn
            // 
            this.publicationDataGridViewTextBoxColumn.DataPropertyName = "Publication";
            this.publicationDataGridViewTextBoxColumn.HeaderText = "Publication";
            this.publicationDataGridViewTextBoxColumn.Name = "publicationDataGridViewTextBoxColumn";
            this.publicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "Book_Price";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "Book_Price";
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookDetailsBindingSource
            // 
            this.bookDetailsBindingSource.DataMember = "Book_Details";
            this.bookDetailsBindingSource.DataSource = this.book_Mgt_System_01DataSet;
            // 
            // book_Mgt_System_01DataSet
            // 
            this.book_Mgt_System_01DataSet.DataSetName = "Book_Mgt_System_01DataSet";
            this.book_Mgt_System_01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksDetailsBindingSource
            // 
            this.booksDetailsBindingSource.DataMember = "Books_Details";
            // 
            // book_DetailsTableAdapter
            // 
            this.book_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Add_New_Book
            // 
            this.btn_Add_New_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Add_New_Book.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Book.Location = new System.Drawing.Point(231, 329);
            this.btn_Add_New_Book.Name = "btn_Add_New_Book";
            this.btn_Add_New_Book.Size = new System.Drawing.Size(233, 45);
            this.btn_Add_New_Book.TabIndex = 4;
            this.btn_Add_New_Book.Text = "Add New Book";
            this.btn_Add_New_Book.UseVisualStyleBackColor = false;
            this.btn_Add_New_Book.Click += new System.EventHandler(this.btn_Add_New_Book_Click);
            // 
            // frm_View_All_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 409);
            this.Controls.Add(this.btn_Add_New_Book);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.dgv_Books_Details);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Books";
            this.Load += new System.EventHandler(this.frm_View_All_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Mgt_System_01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dgv_Books_Details;
        private System.Windows.Forms.BindingSource booksDetailsBindingSource;
        private Book_Mgt_System_01DataSet book_Mgt_System_01DataSet;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource;
        private Book_Mgt_System_01DataSetTableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Add_New_Book;
    }
}