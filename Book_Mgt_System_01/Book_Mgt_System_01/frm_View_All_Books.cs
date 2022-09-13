using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_Mgt_System_01
{
    public partial class frm_View_All_Books : Form
    {
        public frm_View_All_Books()
        {
            InitializeComponent();
        }

        private void frm_View_All_Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book_Mgt_System_01DataSet.Book_Details' table. You can move, or remove it, as needed.
            this.book_DetailsTableAdapter.Fill(this.book_Mgt_System_01DataSet.Book_Details);

        }

        private void btn_Add_New_Book_Click(object sender, EventArgs e)
        {
            frm_Add_New_Book obj = new frm_Add_New_Book();
            obj.Show();
            this.Hide();
        }
    }
}
