namespace Student_Information_Management
{
    partial class frm_Add_Student_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_View_Student_List = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Student_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_Dob = new System.Windows.Forms.Label();
            this.lbl_Student_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Logged_User = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Log_Out.Location = new System.Drawing.Point(968, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(117, 41);
            this.btn_Log_Out.TabIndex = 8;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_View_Student_List
            // 
            this.btn_View_Student_List.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_View_Student_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Student_List.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Student_List.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_View_Student_List.Location = new System.Drawing.Point(235, 457);
            this.btn_View_Student_List.Margin = new System.Windows.Forms.Padding(4);
            this.btn_View_Student_List.Name = "btn_View_Student_List";
            this.btn_View_Student_List.Size = new System.Drawing.Size(331, 64);
            this.btn_View_Student_List.TabIndex = 6;
            this.btn_View_Student_List.Text = "View Student List";
            this.btn_View_Student_List.UseVisualStyleBackColor = false;
            this.btn_View_Student_List.Click += new System.EventHandler(this.btn_View_Student_List_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Save.Location = new System.Drawing.Point(39, 457);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(158, 64);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Student_Name
            // 
            this.tb_Student_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Student_Name.Location = new System.Drawing.Point(348, 213);
            this.tb_Student_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Student_Name.MaxLength = 20;
            this.tb_Student_Name.Name = "tb_Student_Name";
            this.tb_Student_Name.Size = new System.Drawing.Size(551, 34);
            this.tb_Student_Name.TabIndex = 2;
            this.tb_Student_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(348, 131);
            this.tb_Roll_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(551, 34);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Course.Location = new System.Drawing.Point(34, 381);
            this.lbl_Course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(91, 29);
            this.lbl_Course.TabIndex = 11;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_Dob
            // 
            this.lbl_Dob.AutoSize = true;
            this.lbl_Dob.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dob.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Dob.Location = new System.Drawing.Point(34, 302);
            this.lbl_Dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dob.Name = "lbl_Dob";
            this.lbl_Dob.Size = new System.Drawing.Size(58, 29);
            this.lbl_Dob.TabIndex = 12;
            this.lbl_Dob.Text = "Dob";
            // 
            // lbl_Student_Name
            // 
            this.lbl_Student_Name.AutoSize = true;
            this.lbl_Student_Name.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Student_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Student_Name.Location = new System.Drawing.Point(34, 214);
            this.lbl_Student_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Student_Name.Name = "lbl_Student_Name";
            this.lbl_Student_Name.Size = new System.Drawing.Size(166, 29);
            this.lbl_Student_Name.TabIndex = 10;
            this.lbl_Student_Name.Text = "Student Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Roll_No.Location = new System.Drawing.Point(34, 132);
            this.lbl_Roll_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(94, 29);
            this.lbl_Roll_No.TabIndex = 9;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Khaki;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Header.Location = new System.Drawing.Point(270, 18);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(469, 55);
            this.lbl_Header.TabIndex = 7;
            this.lbl_Header.Text = "Add Student Details";
            // 
            // dtp_Dob
            // 
            this.dtp_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Dob.Location = new System.Drawing.Point(348, 297);
            this.dtp_Dob.Name = "dtp_Dob";
            this.dtp_Dob.Size = new System.Drawing.Size(551, 34);
            this.dtp_Dob.TabIndex = 3;
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCA",
            "BBA",
            "BSC.Cs",
            "BA"});
            this.cmb_Course.Location = new System.Drawing.Point(348, 373);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(551, 37);
            this.cmb_Course.TabIndex = 4;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Search.Location = new System.Drawing.Point(763, 458);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(310, 64);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "Search Student";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Controls.Add(this.btn_Log_Out);
            this.panel1.Controls.Add(this.lbl_Logged_User);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 89);
            this.panel1.TabIndex = 14;
            // 
            // lbl_Logged_User
            // 
            this.lbl_Logged_User.AutoSize = true;
            this.lbl_Logged_User.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Logged_User.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_User.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Logged_User.Location = new System.Drawing.Point(1, 0);
            this.lbl_Logged_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Logged_User.Name = "lbl_Logged_User";
            this.lbl_Logged_User.Size = new System.Drawing.Size(156, 25);
            this.lbl_Logged_User.TabIndex = 9;
            this.lbl_Logged_User.Text = "Logged in user";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Reset.Location = new System.Drawing.Point(597, 459);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(142, 63);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // frm_Add_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1083, 574);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_Dob);
            this.Controls.Add(this.btn_View_Student_List);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Student_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Dob);
            this.Controls.Add(this.lbl_Student_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Name = "frm_Add_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Add_Student_Details";
            this.Load += new System.EventHandler(this.frm_Add_Student_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_View_Student_List;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Student_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_Dob;
        private System.Windows.Forms.Label lbl_Student_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DateTimePicker dtp_Dob;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Logged_User;
        private System.Windows.Forms.Button btn_Reset;
    }
}