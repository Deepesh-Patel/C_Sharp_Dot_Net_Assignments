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
    public partial class frm_View_Emp_List : Form
    {
        public frm_View_Emp_List()
        {
            InitializeComponent();
        }

        private void frm_View_Emp_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emp_Mgt_04_DBDataSet2.Emp_List_4' table. You can move, or remove it, as needed.
            this.emp_List_4TableAdapter1.Fill(this.emp_Mgt_04_DBDataSet2.Emp_List_4);
            // TODO: This line of code loads data into the 'emp_Mgt_04_DBDataSet.Emp_List_4' table. You can move, or remove it, as needed.
            

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Dashboard df = new frm_Dashboard();
            df.Show();
            this.Hide();
        }
    }
}
