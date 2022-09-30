using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System_02
{
    public partial class Search_Student : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_02;Integrated Security=True");
        public Search_Student()
        {
            InitializeComponent();
        }
        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Uname.Text = Global_Vars.Uname;
            tb_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * from Student_Details where Roll_No = " + tb_Roll_No.Text + " ", Con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                tb_Mobile_Number.Text = (obj["Mobile_Number"].ToString());
                dtp_DOB.Text = (obj["DOB"].ToString());
                tb_Course.Text = obj.GetString(obj.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("Invalid Roll Number!!!");
                tb_Roll_No.Clear();
                tb_Roll_No.Focus();
            }
            Con_Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_Number.Clear();
            dtp_DOB.ResetText();
            tb_Course.Clear();
            tb_Roll_No.Focus();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            Add_New_Student obj = new Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Students_Click(object sender, EventArgs e)
        {
            frm_View_All_Student obj = new frm_View_All_Student();
            obj.Show();
            this.Hide();
        }

    }
}
