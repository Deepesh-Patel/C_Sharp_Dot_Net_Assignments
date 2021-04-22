using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Mgt_04
{
    public partial class frm_View_Emp_Details_By_Dept : Form
    {
        public frm_View_Emp_Details_By_Dept()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS3;Initial Catalog=Emp_Mgt_04_DB;Integrated Security=True");
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

        private void frm_View_Emp_Details_By_Dept_Load(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select Distinct(Department_Name) From Dept_List", Con);

            var obj = cmd.ExecuteReader();
            cmd.Dispose();

            while (obj.Read())
            {
                cmb_Department.Items.Add(obj.GetString(obj.GetOrdinal("Department_Name")));
            }
            obj.Dispose();
            SqlDataAdapter sda = new SqlDataAdapter(" Select * From Emp_List_4 ", Con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv_Emp_Details.DataSource = dt;
            Con_Close();
        }

        private void btn_Refresh_Grid_Click(object sender, EventArgs e)
        {
            Con_Open();
            cmb_Department.SelectedIndex = -1;
            tb_Emp_ID.Clear();
            SqlDataAdapter sda = new SqlDataAdapter(" Select * From Emp_List_4 ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Emp_Details.DataSource = dt;
            Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Emp_ID.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter(" Select * From Emp_List_4 where Department = '" + cmb_Department.Text + "' And Emp_ID = " + tb_Emp_ID.Text + "  ", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv_Emp_Details.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Please enter Valid emp ID");
            }
            Con_Close();
        }

        private void Load_Employee_Data(object sender, EventArgs e)
        {
            Con_Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Emp_List_4 where Department = '" + cmb_Department.Text + "' ", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_Emp_Details.DataSource = dt;
            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
