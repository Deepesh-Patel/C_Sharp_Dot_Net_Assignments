using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Emp_Management_01
{
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Emp_Mgt_01_DB;Integrated Security=True");
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            {
                Con_Open();
                if (tb_Emp_ID.Text != "" && tb_Emp_Name.Text != "" && tb_City.Text != "" && tb_Mob_No.Text != "" )
                {
                    SqlCommand cmd = new SqlCommand("Insert into Emp_List_01 values(" + tb_Emp_ID.Text + ", '" + tb_Emp_Name.Text + "', '" + tb_City.Text +"', " + tb_Mob_No.Text +" )",Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Emp_ID.Clear();
                    tb_Emp_Name.Clear();
                    tb_City.Clear();
                    tb_Mob_No.Clear();
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

        private void Only_Letter(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
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

        private void btn_View_Employee_List_Click(object sender, EventArgs e)
        {
            frm_View_Emp_Listcs ep = new frm_View_Emp_Listcs();
            ep.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login ob = new frm_Login();
            ob.Show();
            this.Hide();
        }

        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            lbl_Logged_in_User.Text = Global_Vars.Username;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Emp_ID.Clear();
            tb_Emp_Name.Clear();
            tb_City.Clear();
            tb_Mob_No.Clear();
        }
    }
}

