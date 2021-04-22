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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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
        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Count(Emp_ID) from Emp_List_4", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Emp_ID) from Emp_List_4";

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
        void ClearControls()
        {
            lbl_ID.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.ResetText();
            cmb_Department.SelectedIndex = -1;
            tb_Salary.Clear();

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

            private void btn_Save_Click(object sender, EventArgs e)
            {
            Con_Open();
            if (lbl_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_DOB.Text != "" && cmb_Department.Text != "" && tb_Salary.Text != "")
            {
                SqlCommand Cmd = new SqlCommand("Insert into Emp_List_4 values(" + lbl_ID.Text + " ,'" + tb_Name.Text + "' ," + tb_Mob_No.Text + " ,'" + dtp_DOB.Text + "' ,'" + cmb_Department.Text + "' ," + tb_Salary.Text + ")", Con);
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearControls();
                tb_Name.Focus();
            }
            else
            {
                MessageBox.Show("Fill all the information", "Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            Con_Close();
            }

            private void frm_Add_New_Employee_Load(object sender, EventArgs e)
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
                lbl_ID.Text = Convert.ToString(Auto_Incr());
                tb_Name.Focus();
                cmb_Department.SelectedIndex = -1;
            }

            private void btn_Close_Click(object sender, EventArgs e)
            {
                frm_Dashboard de = new frm_Dashboard();
                de.Show();
                this.Hide();
            }

            private void btn_Refresh_Click(object sender, EventArgs e)
            {
                ClearControls();
            }
     }
}
