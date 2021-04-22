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
    public partial class frm_Search_Employee : Form
    {
        public frm_Search_Employee()
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Emp_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Emp_List_4 where Emp_ID = " + tb_Emp_ID.Text + "", Con);
                var obj = cmd.ExecuteReader();
                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    tb_Mob_No.Text = (obj["Mob_No"].ToString());
                    dtp_DOB.Text = (obj["Dob"].ToString());
                    cmb_Department.Text = obj.GetString(obj.GetOrdinal("Department"));
                    tb_Salary.Text = (obj["Salary"].ToString());
                }
                else
                {
                    MessageBox.Show("Incorrect ID no entered!!");
                    ClearControls();
                    tb_Emp_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter emp ID");
            }
            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Dashboard dd = new frm_Dashboard();
            dd.Show();
            this.Hide();
        }
        void ClearControls()
        {
            tb_Emp_ID.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.ResetText();
            cmb_Department.SelectedIndex = -1;
            tb_Salary.Clear();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Emp_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_DOB.Text != "" && cmb_Department.Text != "" && tb_Salary.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Emp_List_4 Set Name = '" + tb_Name.Text + "', Mob_No = " + tb_Mob_No.Text + ", Dob = '" + dtp_DOB.Text + "', Department = '" + cmb_Department.Text + "', Salary = " + tb_Salary.Text + " where Emp_ID = " + tb_Emp_ID.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
            Con_Close();
        }

        private void frm_Search_Employee_Load(object sender, EventArgs e)
        {
            Con_Open();
            cmb_Department.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select Distinct(Department_Name) from Dept_List", Con);
            var obj = cmd.ExecuteReader();
            while (obj.Read())
            {
                cmb_Department.Items.Add(obj.GetString(obj.GetOrdinal("Department_Name")));
            }
            obj.Dispose();
            Con_Close();
            tb_Name.Focus();
            cmb_Department.SelectedIndex = -1;
        }
    }
}
