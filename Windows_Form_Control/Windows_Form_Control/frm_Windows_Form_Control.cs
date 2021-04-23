using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Windows_Form_Control
{
    public partial class frm_Windows_Form_Control : Form
    {
        public frm_Windows_Form_Control()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Output.Clear();
            lbl_Name_Note.ResetText();
            lbl_Gender_Note.ResetText();
            lbl_Shift_Note.ResetText();
            rd_btn_Male.Checked = false;
            rd_btn_Female.Checked = false;
            rd_btn_Morning.Checked = false;
            rd_btn_Evening.Checked = false;
            rd_btn_Night.Checked = false;
        }

        private void frm_Windows_Form_Control_Load(object sender, EventArgs e)
        {
            tb_Name.Focus();
            Clear_Controls();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            {
                lbl_Name_Note.Text = "Please enter the name first.";
                tb_Name.Focus();
            }
            else if (rd_btn_Male.Checked == false && rd_btn_Female.Checked == false)
            {
                lbl_Gender_Note.Text = "Please select the gender";
                gb_Gender.BackColor = Color.Tan;
            }
            else if (rd_btn_Morning.Checked == false && rd_btn_Evening.Checked == false && rd_btn_Night.Checked == false)
            {
                lbl_Shift_Note.Text = "Please select the shift timing";
                gb_Shift_Time.BackColor = Color.Tan;
            }
            else
            {
                string Gender;
                string ShiftTime;

                if (rd_btn_Male.Checked == true)
                {
                    Gender = rd_btn_Male.Text;
                }
                else
                {
                    Gender = rd_btn_Female.Text;
                }

                if (rd_btn_Morning.Checked == true)
                {
                    ShiftTime = rd_btn_Morning.Text;
                }
                else if (rd_btn_Evening.Checked == true)
                {
                    ShiftTime = rd_btn_Evening.Text;
                }
                else
                {
                    ShiftTime = rd_btn_Night.Text;
                }

                tb_Output.Text = tb_Name.Text + " is " + Gender + " Employee with " + ShiftTime + " shift.";

                string Output = "";

                Output = tb_Name.Text + " is ";

                if (rd_btn_Male.Checked == true)
                {
                    Output += rd_btn_Male.Text;
                }
                else
                {
                    Output += rd_btn_Female.Text;
                }

                Output += " Employee with ";

                if (rd_btn_Morning.Checked == true)
                {
                    Output += rd_btn_Morning.Text;
                }
                else if (rd_btn_Evening.Checked == true)
                {
                    Output += rd_btn_Evening.Text;
                }
                else
                {
                    Output += rd_btn_Night.Text;
                }

                Output += " shift.";

                tb_Output.Text = Output;
            }

        }

        private void tb_Name_TextChanged(object sender, EventArgs e)
        {
            lbl_Name_Note.Text = "";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Gender_Checked_Change(object sender, EventArgs e)
        {
            lbl_Gender_Note.Text = "";
            gb_Gender.BackColor = Color.CornflowerBlue;
        }

        private void Shift_Time_Checked_Change(object sender, EventArgs e)
        {
            lbl_Shift_Note.Text = "";
            gb_Shift_Time.BackColor = Color.CornflowerBlue;
        }
    }
}
