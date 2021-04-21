using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class Emp_Management_MDIParent : Form
    {
        

        public Emp_Management_MDIParent()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee ob = new frm_Add_New_Employee();
            ob.Show();
           
        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Employee_List obj = new frm_View_Employee_List();
            obj.Show();
            
        }

        private void searchEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Employee aa = new frm_Search_Employee();
            aa.Show();
            
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login lo = new frm_Login();
            lo.Show();
            this.Close();
        }

        private void Emp_Management_MDIParent_Load(object sender, EventArgs e)
        {
            lbl_Logged_in_user.Text = Global_Vars.Username;
        }


    }
}
