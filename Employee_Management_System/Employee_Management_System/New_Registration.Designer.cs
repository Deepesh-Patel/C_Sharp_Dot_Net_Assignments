namespace Employee_Management_System
{
    partial class frm_New_Registration
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Login_Header = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lnl_Show = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(239, 410);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(122, 51);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(499, 287);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(299, 30);
            this.tb_Password.TabIndex = 10;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(499, 194);
            this.tb_Username.MaxLength = 10;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(299, 30);
            this.tb_Username.TabIndex = 7;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(216, 278);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(136, 38);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(216, 187);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(145, 38);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Login_Header
            // 
            this.lbl_Login_Header.AutoSize = true;
            this.lbl_Login_Header.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Header.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Login_Header.Location = new System.Drawing.Point(242, 19);
            this.lbl_Login_Header.Name = "lbl_Login_Header";
            this.lbl_Login_Header.Size = new System.Drawing.Size(445, 62);
            this.lbl_Login_Header.TabIndex = 12;
            this.lbl_Login_Header.Text = "New Registration";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(508, 414);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(191, 42);
            this.btn_Login.TabIndex = 13;
            this.btn_Login.Text = "Login Page";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lnl_Show
            // 
            this.lnl_Show.AutoSize = true;
            this.lnl_Show.Location = new System.Drawing.Point(756, 267);
            this.lnl_Show.Name = "lnl_Show";
            this.lnl_Show.Size = new System.Drawing.Size(42, 17);
            this.lnl_Show.TabIndex = 14;
            this.lnl_Show.TabStop = true;
            this.lnl_Show.Text = "Show";
            this.lnl_Show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnl_Show_LinkClicked);
            // 
            // frm_New_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1014, 646);
            this.Controls.Add(this.lnl_Show);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Login_Header);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Name = "frm_New_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Login_Header;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel lnl_Show;
    }
}