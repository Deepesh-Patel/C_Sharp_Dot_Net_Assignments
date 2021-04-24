using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frm_User_Control_Add_Table
{
    public partial class frm_Add_Bill : Form
    {
        public frm_Add_Bill()
        {
            InitializeComponent();
        }
        static int Table_Cnt = 1;
        int x = 50;
        int y = 100;

        private void btn_Add_New_Table_Click(object sender, EventArgs e)
        {
            UC_Table obj = new UC_Table();

            obj.Location = new System.Drawing.Point(x, y);
            obj.Size = new System.Drawing.Size(300, 300);

            Label Name = new Label();
            Name.Text = Table_Cnt.ToString();
            obj.SetTableNo = Name;

            this.Controls.Add(obj);

            x = x + 380;

            if (Table_Cnt % 4 == 0)
            {
                x = 50;
                y = y + 380;
            }
            Table_Cnt++;       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
    }
}
