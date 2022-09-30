using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System_02
{
    public partial class frm_View_All_Student : Form
    {
        public frm_View_All_Student()
        {
            InitializeComponent();
        }

        private void frm_View_All_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_02DataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Management_System_02DataSet.Student_Details);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
