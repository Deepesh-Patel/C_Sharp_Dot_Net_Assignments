using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Employee_Mgt_04
{
    public partial class frm_Upload_Show_Image : Form
    {
        public frm_Upload_Show_Image()
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

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files(*.jpg; *.jpeg;)| *.jpg; *.jpeg;";

            if(OFD.ShowDialog() == DialogResult.OK)
            {
               pb_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            Con_Open();
            ImageConverter IC = new ImageConverter();
            byte[] imgArray = (byte[])IC.ConvertTo(pb_Image.Image, typeof(byte[]));
            string str = "Insert Into Image_List (Image) Values (@img)";
            SqlCommand cmd = new SqlCommand(str, Con);
            cmd.Parameters.Add("@img", SqlDbType.Image).Value = imgArray;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Image Uploaded Successfully !!");
            Con_Close();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select Image From Image_List where Image_ID = " + tb_Image_ID.Text + " ", Con);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Image"]);
                pb_Show_Image.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Invalid Image ID !!");
                tb_Image_ID.Clear();
            }
            Con_Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
