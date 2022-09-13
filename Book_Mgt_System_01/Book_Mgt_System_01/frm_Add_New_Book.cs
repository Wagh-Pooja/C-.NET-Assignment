using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Book_Mgt_System_01
{
    public partial class frm_Add_New_Book : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Book_Mgt_System_01;Integrated Security=True");

        public frm_Add_New_Book()
        {
            InitializeComponent();
        }

        void Connection_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }

        }
        void Connection_Closed()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }


        private void frm_Add_New_Book_Load(object sender, EventArgs e)
        {

        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Is_Price(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connection_Open();

            if (tb_Book_ID.Text != "" && tb_Book_Name.Text != "" && tb_Publication.Text != "" && tb_Book_Price.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into Book_Details Values (" + tb_Book_ID.Text + ",'" + tb_Book_Name.Text + "','" + tb_Publication.Text + "'," + tb_Book_Price.Text + ")", Con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Save Successfully !!!");

                tb_Book_ID.Clear();
                tb_Book_Name.Clear();
                tb_Publication.Clear();
                tb_Book_Price.Clear();

                tb_Book_ID.Focus();
            }
            else
            {
                MessageBox.Show("First Fill the All the fields!!!");
            }

            Connection_Closed();
        }

        private void btn_View_All_Books_Click(object sender, EventArgs e)
        {
            frm_View_All_Books obj = new frm_View_All_Books();
            obj.Show();
            this.Hide();
        }
    }
}
