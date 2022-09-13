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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Please Enter your Username and Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "q" && tb_Password.Text == "q")
            {
                MessageBox.Show("Login Successfull !!!");
                frm_Add_New_Book obj = new frm_Add_New_Book();
                obj.Show();
                this.Hide();
            }

            else
            {
                lbl_Note.Text = "Please Enter Valid Details";

            }

            tb_Username.Text = "";
            tb_Password.Text = "";

            tb_Username.Focus();

        }
    }
}
