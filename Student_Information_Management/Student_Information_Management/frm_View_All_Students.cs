using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Information_Management
{
    public partial class frm_View_All_Students : Form
    {
        public frm_View_All_Students()
        {
            InitializeComponent();
        }

        private void frm_View_All_Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mgt_DBDataSet.Student_List' table. You can move, or remove it, as needed.
            this.student_ListTableAdapter.Fill(this.student_Mgt_DBDataSet.Student_List);
            lbl_Logged_User.Text = Global_Vars.Username;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details ad = new frm_Add_Student_Details();
            ad.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login lg = new frm_Login();
            lg.Show();
            this.Hide();
        }
    }
}
