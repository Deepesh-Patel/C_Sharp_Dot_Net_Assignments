namespace Employee_Management_System
{
    partial class frm_Login
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
            this.lbl_Login_Header = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.lnl_Show = new System.Windows.Forms.LinkLabel();
            this.btn_New_Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login_Header
            // 
            this.lbl_Login_Header.AutoSize = true;
            this.lbl_Login_Header.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Header.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Login_Header.Location = new System.Drawing.Point(276, 9);
            this.lbl_Login_Header.Name = "lbl_Login_Header";
            this.lbl_Login_Header.Size = new System.Drawing.Size(313, 62);
            this.lbl_Login_Header.TabIndex = 0;
            this.lbl_Login_Header.Text = "Login Form";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(105, 144);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(145, 38);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(105, 235);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(136, 38);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(388, 151);
            this.tb_Username.MaxLength = 10;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(299, 30);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(388, 242);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(299, 30);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Enabled = false;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(153, 374);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(167, 42);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Note.Location = new System.Drawing.Point(273, 309);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(309, 25);
            this.lbl_Note.TabIndex = 6;
            this.lbl_Note.Text = "Please Enter Username && Password";
            // 
            // lnl_Show
            // 
            this.lnl_Show.AutoSize = true;
            this.lnl_Show.Location = new System.Drawing.Point(645, 222);
            this.lnl_Show.Name = "lnl_Show";
            this.lnl_Show.Size = new System.Drawing.Size(42, 17);
            this.lnl_Show.TabIndex = 7;
            this.lnl_Show.TabStop = true;
            this.lnl_Show.Text = "Show";
            this.lnl_Show.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnl_Show_LinkClicked);
            // 
            // btn_New_Registration
            // 
            this.btn_New_Registration.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New_Registration.Location = new System.Drawing.Point(401, 374);
            this.btn_New_Registration.Name = "btn_New_Registration";
            this.btn_New_Registration.Size = new System.Drawing.Size(254, 42);
            this.btn_New_Registration.TabIndex = 12;
            this.btn_New_Registration.Text = "New Registration";
            this.btn_New_Registration.UseVisualStyleBackColor = true;
            this.btn_New_Registration.Click += new System.EventHandler(this.btn_New_Registration_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(854, 498);
            this.Controls.Add(this.btn_New_Registration);
            this.Controls.Add(this.lnl_Show);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login_Header);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login_Header;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.LinkLabel lnl_Show;
        private System.Windows.Forms.Button btn_New_Registration;
    }
}

