namespace Employee_Management_System
{
    partial class frm_Search_Employee
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
            this.lbl_Search_Employee = new System.Windows.Forms.Label();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Dob = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Search_Employee
            // 
            this.lbl_Search_Employee.AutoSize = true;
            this.lbl_Search_Employee.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Employee.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Search_Employee.Location = new System.Drawing.Point(273, 9);
            this.lbl_Search_Employee.Name = "lbl_Search_Employee";
            this.lbl_Search_Employee.Size = new System.Drawing.Size(442, 62);
            this.lbl_Search_Employee.TabIndex = 2;
            this.lbl_Search_Employee.Text = "Search Employee";
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_ID.Location = new System.Drawing.Point(305, 88);
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(382, 34);
            this.tb_Emp_ID.TabIndex = 1;
            this.tb_Emp_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Emp_ID
            // 
            this.lbl_Emp_ID.AutoSize = true;
            this.lbl_Emp_ID.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_ID.Location = new System.Drawing.Point(164, 84);
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            this.lbl_Emp_ID.Size = new System.Drawing.Size(110, 38);
            this.lbl_Emp_ID.TabIndex = 4;
            this.lbl_Emp_ID.Text = "Emp ID";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(734, 84);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 38);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_Dob
            // 
            this.dtp_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Dob.Location = new System.Drawing.Point(406, 327);
            this.dtp_Dob.Name = "dtp_Dob";
            this.dtp_Dob.Size = new System.Drawing.Size(382, 34);
            this.dtp_Dob.TabIndex = 4;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(406, 393);
            this.tb_Salary.MaxLength = 20;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(382, 34);
            this.tb_Salary.TabIndex = 5;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(406, 262);
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(382, 34);
            this.tb_Mob_No.TabIndex = 3;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(406, 188);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(382, 34);
            this.tb_Name.TabIndex = 2;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(204, 389);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(94, 38);
            this.lbl_Salary.TabIndex = 8;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Dob
            // 
            this.lbl_Dob.AutoSize = true;
            this.lbl_Dob.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dob.Location = new System.Drawing.Point(204, 325);
            this.lbl_Dob.Name = "lbl_Dob";
            this.lbl_Dob.Size = new System.Drawing.Size(71, 38);
            this.lbl_Dob.TabIndex = 7;
            this.lbl_Dob.Text = "Dob";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(204, 258);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(123, 38);
            this.lbl_Mob_No.TabIndex = 10;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(204, 184);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(93, 38);
            this.lbl_Name.TabIndex = 9;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(211, 489);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(118, 50);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(715, 489);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(113, 43);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(467, 489);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(113, 43);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_Search_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1081, 638);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dtp_Dob);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Dob);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Emp_ID);
            this.Controls.Add(this.lbl_Emp_ID);
            this.Controls.Add(this.lbl_Search_Employee);
            this.Name = "frm_Search_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search_Employee;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_Dob;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Dob;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Update;
    }
}