namespace Employee_Management_System
{
    partial class Emp_Management_MDIParent
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Logged_in_user = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowDrop = true;
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.searchEmployeeToolStripMenuItem,
            this.employeeListToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1292, 43);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(121, 39);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // searchEmployeeToolStripMenuItem
            // 
            this.searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            this.searchEmployeeToolStripMenuItem.Size = new System.Drawing.Size(194, 39);
            this.searchEmployeeToolStripMenuItem.Text = "Search Employee";
            this.searchEmployeeToolStripMenuItem.Click += new System.EventHandler(this.searchEmployeeToolStripMenuItem_Click);
            // 
            // employeeListToolStripMenuItem
            // 
            this.employeeListToolStripMenuItem.Name = "employeeListToolStripMenuItem";
            this.employeeListToolStripMenuItem.Size = new System.Drawing.Size(167, 39);
            this.employeeListToolStripMenuItem.Text = "Employee List";
            this.employeeListToolStripMenuItem.Click += new System.EventHandler(this.employeeListToolStripMenuItem_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1179, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(113, 43);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Logged_in_user
            // 
            this.lbl_Logged_in_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Logged_in_user.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Logged_in_user.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_in_user.Location = new System.Drawing.Point(840, -1);
            this.lbl_Logged_in_user.Name = "lbl_Logged_in_user";
            this.lbl_Logged_in_user.Size = new System.Drawing.Size(222, 43);
            this.lbl_Logged_in_user.TabIndex = 5;
            this.lbl_Logged_in_user.Text = "Logged in User";
            this.lbl_Logged_in_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Emp_Management_MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 643);
            this.Controls.Add(this.lbl_Logged_in_user);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Emp_Management_MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emp Management MDIParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Emp_Management_MDIParent_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeListToolStripMenuItem;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Logged_in_user;
    }
}



