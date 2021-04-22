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
    public partial class frm_Add_New_Department : Form
    {
        public frm_Add_New_Department()
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
            SqlCommand Cmd = new SqlCommand("Select Count(Department_ID) from Dept_List", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Department_ID) from Dept_List";

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
        void Clear_Controls()
        {
            lbl_ID.Text = Convert.ToString(Auto_Incr());
            tb_Dept_Name.Clear();
        }

        private void frm_Add_New_Course_Load(object sender, EventArgs e)
        {
            tb_Dept_Name.Focus();
            lbl_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (lbl_ID.Text != "" && tb_Dept_Name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into Dept_List values(" + lbl_ID.Text + " ,'" + tb_Dept_Name.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill all the information", "Incomplete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Dashboard ob = new frm_Dashboard();
            ob.Show();
            this.Hide();
        }
    }
}
