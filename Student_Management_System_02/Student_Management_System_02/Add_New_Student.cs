﻿using System;
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
    public partial class Add_New_Student : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_02;Integrated Security=True");
        public Add_New_Student()
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
        void Clear_Controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Text = "";
            tb_Mobile_Number.Text = "";
            dtp_DOB.Text = "";
            cmb_Course.SelectedIndex = -1;
            tb_Roll_No.Focus();
        }
        private void Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_Logged_In_Uname.Text = Global_Vars.Uname;
            tb_Roll_No.Focus();
            cmb_Course.SelectedIndex = -1;
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.CapsLock) || (e.KeyChar == (char)Keys.ShiftKey)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            Con_Open();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_Number.Text != "" && dtp_DOB.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;

                cmd.CommandText = "Insert into Student_Details(Roll_No,Name,Mobile_Number,DOB,Course) values (" + tb_Roll_No.Text + ",'" + tb_Name.Text + "'," + tb_Mobile_Number.Text + ",'" + dtp_DOB.Text + "','" + cmb_Course.Text + "')";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Saved Successfully", "SucCess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("first fill all the fields!!!");
            }

            Con_Close();
        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            frm_View_All_Student obj = new frm_View_All_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search_Student obj = new Search_Student();
            obj.Show();
            this.Hide();
        }
    }
}
