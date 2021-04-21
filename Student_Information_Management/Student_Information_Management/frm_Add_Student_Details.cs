using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Information_Management
{
    public partial class frm_Add_Student_Details : Form
    {
        public frm_Add_Student_Details()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Mgt_DB;Integrated Security=True");

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
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Roll_No.Text != "" && tb_Student_Name.Text != "" && dtp_Dob.Text != "" && cmb_Course.Text != "" )
            {
                 SqlCommand cmd = new SqlCommand("Insert into Student_List values(" + tb_Roll_No.Text + ", '" + tb_Student_Name.Text + "', '" + dtp_Dob.Text + "', '"+ cmb_Course.Text + "')",Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Roll_No.Clear();
                tb_Student_Name.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the information", "Incomplete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            Con_Close();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login ob = new frm_Login();
            ob.Show();
            this.Hide();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_All_Students vb = new frm_View_All_Students();
            vb.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student se = new frm_Search_Student();
            se.Show();
            this.Hide();
        }

        private void frm_Add_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_Logged_User.Text = Global_Vars.Username;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Student_Name.Clear();
            dtp_Dob.ResetText();
            cmb_Course.SelectedIndex = -1;
        }

    }
}
