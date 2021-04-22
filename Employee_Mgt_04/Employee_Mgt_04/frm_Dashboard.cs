using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Mgt_04
{
    public partial class frm_Dashboard : Form
    {
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ob = new frm_Add_New_Employee();
            ob.Show();
            ob.MdiParent = this;
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            this.Close();
            obj.Show();
        }

        private void viewEmpListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Emp_List de = new frm_View_Emp_List();
            de.Show();
            de.MdiParent = this;
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee ss = new frm_Search_Employee();
            ss.Show();
            ss.MdiParent = this;
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Department fm = new frm_Add_New_Department();
            fm.Show();
            fm.MdiParent = this;
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
            lbl_LoggedIn_User.Text = Global_Vars.Username;
        }

        private void viewEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Emp_Details_By_Dept ff = new frm_View_Emp_Details_By_Dept();
            ff.Show();
            ff.MdiParent = this;
        }

        private void uploadPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Upload_Show_Image obj = new frm_Upload_Show_Image();
            obj.Show();
            obj.MdiParent = this;
        }
    }
}
