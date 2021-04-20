using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emp_Management_01
{
    public partial class frm_View_Emp_Listcs : Form
    {
        public frm_View_Emp_Listcs()
        {
            InitializeComponent();
        }

        private void frm_View_Emp_Listcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_Mgt_01_DBDataSet.Emp_List_01' table. You can move, or remove it, as needed.
            this.emp_List_01TableAdapter.Fill(this.emp_Mgt_01_DBDataSet.Emp_List_01);
            lbl_Logged_in_User.Text = Global_Vars.Username;

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee();
            obj.Show();
            this.Hide();
        }
    }
}
