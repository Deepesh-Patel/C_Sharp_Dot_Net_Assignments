﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Information_Management
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Username && Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Admin" && tb_Password.Text == "a123")
            {
                MessageBox.Show("Login Successfull!!");
                Global_Vars.Username = "Welcome " + tb_Username.Text;
                frm_Add_Student_Details ad = new frm_Add_Student_Details();
                ad.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Please Enter Valid Details.";
                lbl_Note.ForeColor = Color.Red;


            }

            tb_Username.Clear();
            tb_Password.Text = "";

            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
            tb_Username.Focus();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
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
    }
}


