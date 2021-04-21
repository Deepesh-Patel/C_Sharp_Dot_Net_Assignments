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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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

        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(Emp_ID) from Employee_List_02", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Emp_ID) from Employee_List_02";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }

            Con_Close();

            return Cnt;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            {
                Con_Open();
                if (tb_Emp_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_Dob.Text != "" && tb_Salary.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Insert into Employee_List_02 values(" + tb_Emp_ID.Text + ", '" + tb_Name.Text + "', " + tb_Mob_No.Text + ", '" + dtp_Dob.Text + "', " + tb_Salary.Text + " )", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Emp_ID.Text = Convert.ToString(Auto_Incr());
                    tb_Name.Clear();
                    tb_Mob_No.Clear();
                    dtp_Dob.ResetText();
                    tb_Salary.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Fill all the information", "Incomplete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

                Con_Close();
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
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Mob(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Alpha_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Emp_ID.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_Dob.ResetText();
            tb_Salary.Clear();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Emp_Management_MDIParent obj = new Emp_Management_MDIParent();
            obj.Show();
            this.Hide();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            tb_Emp_ID.Text = Convert.ToString(Auto_Incr());
        }
    }
}   

