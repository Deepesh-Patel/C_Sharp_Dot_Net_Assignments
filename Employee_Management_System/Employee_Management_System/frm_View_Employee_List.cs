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
    public partial class frm_View_Employee_List : Form
    {
        public frm_View_Employee_List()
        {
            InitializeComponent();
        }

        private void frm_View_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_Management_02_DBDataSet.Employee_List_02' table. You can move, or remove it, as needed.
            this.employee_List_02TableAdapter.Fill(this.emp_Management_02_DBDataSet.Employee_List_02);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Emp_Management_MDIParent ad = new Emp_Management_MDIParent();
            ad.Show();
            this.Hide();
        }
    }
}
