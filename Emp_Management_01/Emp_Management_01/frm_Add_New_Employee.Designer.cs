namespace Emp_Management_01
{
    partial class frm_Add_New_Employee
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
            this.btn_View_Employee_List = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_Emp_Name = new System.Windows.Forms.TextBox();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Logged_in_User = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Log_Out.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Log_Out.Location = new System.Drawing.Point(1078, 0);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(117, 41);
            this.btn_Log_Out.TabIndex = 30;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_View_Employee_List
            // 
            this.btn_View_Employee_List.BackColor = System.Drawing.Color.DarkRed;
            this.btn_View_Employee_List.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Employee_List.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_View_Employee_List.Location = new System.Drawing.Point(691, 567);
            this.btn_View_Employee_List.Margin = new System.Windows.Forms.Padding(4);
            this.btn_View_Employee_List.Name = "btn_View_Employee_List";
            this.btn_View_Employee_List.Size = new System.Drawing.Size(420, 64);
            this.btn_View_Employee_List.TabIndex = 28;
            this.btn_View_Employee_List.Text = "View Employee List";
            this.btn_View_Employee_List.UseVisualStyleBackColor = false;
            this.btn_View_Employee_List.Click += new System.EventHandler(this.btn_View_Employee_List_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Save.Location = new System.Drawing.Point(80, 567);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(203, 64);
            this.btn_Save.TabIndex = 29;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(436, 421);
            this.tb_Mob_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(435, 33);
            this.tb_Mob_No.TabIndex = 27;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Mob);
            // 
            // tb_City
            // 
            this.tb_City.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_City.Location = new System.Drawing.Point(436, 339);
            this.tb_City.Margin = new System.Windows.Forms.Padding(4);
            this.tb_City.MaxLength = 20;
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(435, 33);
            this.tb_City.TabIndex = 26;
            this.tb_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Letter);
            // 
            // tb_Emp_Name
            // 
            this.tb_Emp_Name.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Name.Location = new System.Drawing.Point(436, 255);
            this.tb_Emp_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Emp_Name.MaxLength = 30;
            this.tb_Emp_Name.Name = "tb_Emp_Name";
            this.tb_Emp_Name.Size = new System.Drawing.Size(435, 33);
            this.tb_Emp_Name.TabIndex = 25;
            this.tb_Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_ID.Location = new System.Drawing.Point(436, 173);
            this.tb_Emp_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Emp_ID.MaxLength = 5;
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(435, 33);
            this.tb_Emp_ID.TabIndex = 20;
            this.tb_Emp_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_Mob_No.Location = new System.Drawing.Point(212, 424);
            this.lbl_Mob_No.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(100, 29);
            this.lbl_Mob_No.TabIndex = 23;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_City.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_City.Location = new System.Drawing.Point(212, 343);
            this.lbl_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(57, 29);
            this.lbl_City.TabIndex = 24;
            this.lbl_City.Text = "City";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_Emp_Name.Location = new System.Drawing.Point(212, 255);
            this.lbl_Emp_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(138, 29);
            this.lbl_Emp_Name.TabIndex = 22;
            this.lbl_Emp_Name.Text = "Emp Name";
            // 
            // lbl_Emp_ID
            // 
            this.lbl_Emp_ID.AutoSize = true;
            this.lbl_Emp_ID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_ID.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_Emp_ID.Location = new System.Drawing.Point(212, 173);
            this.lbl_Emp_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            this.lbl_Emp_ID.Size = new System.Drawing.Size(105, 29);
            this.lbl_Emp_ID.TabIndex = 21;
            this.lbl_Emp_ID.Text = "Emp ID";
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Header.Location = new System.Drawing.Point(438, 11);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(343, 55);
            this.lbl_Header.TabIndex = 19;
            this.lbl_Header.Text = "Add Employee";
            // 
            // lbl_Logged_in_User
            // 
            this.lbl_Logged_in_User.AutoSize = true;
            this.lbl_Logged_in_User.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_in_User.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Logged_in_User.Location = new System.Drawing.Point(4, 0);
            this.lbl_Logged_in_User.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Logged_in_User.Name = "lbl_Logged_in_User";
            this.lbl_Logged_in_User.Size = new System.Drawing.Size(176, 29);
            this.lbl_Logged_in_User.TabIndex = 21;
            this.lbl_Logged_in_User.Text = "Logged in user";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Controls.Add(this.btn_Log_Out);
            this.panel1.Controls.Add(this.lbl_Logged_in_User);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 81);
            this.panel1.TabIndex = 31;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Reset.Location = new System.Drawing.Point(427, 567);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(143, 60);
            this.btn_Reset.TabIndex = 32;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // frm_Add_New_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1195, 703);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_View_Employee_List);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_City);
            this.Controls.Add(this.tb_Emp_Name);
            this.Controls.Add(this.tb_Emp_ID);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Emp_ID);
            this.Name = "frm_Add_New_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Employee";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Button btn_View_Employee_List;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_Emp_Name;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Logged_in_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Reset;
    }
}