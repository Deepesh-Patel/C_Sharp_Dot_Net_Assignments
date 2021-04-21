using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Search_Employee : Form
    {
        public frm_Search_Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS3;Initial Catalog=Emp_Management_02_DB;Integrated Security=True");
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Emp_ID.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select * From Employee_List_02 where Emp_ID = " + tb_Emp_ID.Text + "", Con);
                var obj = cmd.ExecuteReader();
                if (obj.Read())
                {
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    tb_Mob_No.Text = (obj["Mob_No"].ToString());
                    dtp_Dob.Text = (obj["Dob"].ToString());
                    tb_Salary.Text = (obj["Salary"].ToString());
                }
                else
                {
                    MessageBox.Show("Incorrect ID no entered!!");
                    tb_Emp_ID.Clear();
                    tb_Emp_ID.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter emp ID");
            }
            Con_Close();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Emp_ID.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_Dob.ResetText();
            tb_Salary.Clear();

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Emp_Management_MDIParent ob = new Emp_Management_MDIParent();
            ob.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Emp_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_Dob.Text != "" && tb_Salary.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update Employee_List_02 Set Name = '" + tb_Name.Text + "' ,Mob_No = " + tb_Mob_No.Text + " ,Dob = '" + dtp_Dob.Text + "' ,Salary = " + tb_Salary.Text +" where Emp_ID = " + tb_Emp_ID.Text + "", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Emp_ID.Clear();
                tb_Name.Clear();
                tb_Mob_No.Clear();
                dtp_Dob.ResetText();
                tb_Salary.Clear();
            }
            else
            {
                MessageBox.Show("Invalid ID");
            }
            Con_Close();
        }

    }
}
