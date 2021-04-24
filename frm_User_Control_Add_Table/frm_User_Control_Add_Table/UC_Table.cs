using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frm_User_Control_Add_Table
{
    public partial class UC_Table : UserControl
    {
        public UC_Table()
        {
            InitializeComponent();
        }
        public Label SetTableNo
        {
            get
            {
                return lbl_Value;
            }
            set
            {
                lbl_Value.Text = value.Text;
            }
        }
    }
}
