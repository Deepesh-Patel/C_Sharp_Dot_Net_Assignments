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
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * From Student_List where Roll_No = " + tb_Roll_No.Text + "", Con);
            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Student_Name.Text = obj.GetString(obj.GetOrdinal("Student_Name"));
                dtp_Dob.Text = (obj["Dob"].ToString());
                cmb_Course.Text = obj.GetString(obj.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("Incorrect Roll no entered!!");
                tb_Roll_No.Clear();
                tb_Roll_No.Focus();
                btn_Search.Enabled = false;
            }
            Con_Close();
        }

        private void btn_View_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_All_Students ss = new frm_View_All_Students();
            ss.Show();
            this.Hide();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login ll = new frm_Login();
            ll.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details add = new frm_Add_Student_Details();
            add.Show();
            this.Hide();
        }

        private void frm_Search_Student_Load(object sender, EventArgs e)
        {
            lbl_Logged_User.Text = Global_Vars.Username;
        }

        private void tb_Roll_No_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {

            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
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
