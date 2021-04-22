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
    public partial class frm_New_Register : Form
    {
        public frm_New_Register()
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

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if(tb_Username.Text != "" && tb_Password.Text != "")
            {
            SqlCommand Cmd = new SqlCommand("Insert into Login_Table values('" +tb_Username.Text + "' ,'" +tb_Password.Text + "')",Con);
            Cmd.ExecuteNonQuery();
            MessageBox.Show("Record Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tb_Username.Clear();
            tb_Password.Clear();
            }
            else
            {
                 MessageBox.Show("Fill all the information", "Incomplete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            Con_Close();        
        }

        private void btn_Login_Page_Click(object sender, EventArgs e)
        {
            frm_Login lk = new frm_Login();
            lk.Show();
            this.Hide();
        }

        private void lnl_Show_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnl_Show.Text == "Show")
            {
                lnl_Show.Text = "Hide";
                tb_Password.PasswordChar = '\0';
            }
            else
            {
                lnl_Show.Text = "Show";
                tb_Password.PasswordChar = '*';
            }       
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
