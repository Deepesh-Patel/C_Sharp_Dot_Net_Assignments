namespace Employee_Mgt_04
{
    partial class frm_Add_New_Department
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Dept_ID = new System.Windows.Forms.Label();
            this.lbl_Dept_Name = new System.Windows.Forms.Label();
            this.tb_Dept_Name = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 81);
            this.panel1.TabIndex = 5;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Header.Location = new System.Drawing.Point(93, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(546, 62);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = "Add New Department";
            // 
            // lbl_Dept_ID
            // 
            this.lbl_Dept_ID.AutoSize = true;
            this.lbl_Dept_ID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Dept_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept_ID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Dept_ID.Location = new System.Drawing.Point(157, 119);
            this.lbl_Dept_ID.Name = "lbl_Dept_ID";
            this.lbl_Dept_ID.Size = new System.Drawing.Size(199, 31);
            this.lbl_Dept_ID.TabIndex = 31;
            this.lbl_Dept_ID.Text = "Department ID";
            // 
            // lbl_Dept_Name
            // 
            this.lbl_Dept_Name.AutoSize = true;
            this.lbl_Dept_Name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Dept_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept_Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Dept_Name.Location = new System.Drawing.Point(157, 249);
            this.lbl_Dept_Name.Name = "lbl_Dept_Name";
            this.lbl_Dept_Name.Size = new System.Drawing.Size(235, 31);
            this.lbl_Dept_Name.TabIndex = 31;
            this.lbl_Dept_Name.Text = "Department Name";
            // 
            // tb_Dept_Name
            // 
            this.tb_Dept_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dept_Name.Location = new System.Drawing.Point(163, 303);
            this.tb_Dept_Name.MaxLength = 20;
            this.tb_Dept_Name.Name = "tb_Dept_Name";
            this.tb_Dept_Name.Size = new System.Drawing.Size(431, 40);
            this.tb_Dept_Name.TabIndex = 1;
            this.tb_Dept_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Save.Location = new System.Drawing.Point(163, 407);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(140, 46);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Close.Location = new System.Drawing.Point(407, 407);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(140, 46);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_ID.Location = new System.Drawing.Point(157, 161);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(50, 31);
            this.lbl_ID.TabIndex = 31;
            this.lbl_ID.Text = "ID";
            // 
            // frm_Add_New_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(726, 569);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Dept_Name);
            this.Controls.Add(this.lbl_Dept_Name);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Dept_ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Add_New_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Add_New_Course_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Dept_ID;
        private System.Windows.Forms.Label lbl_Dept_Name;
        private System.Windows.Forms.TextBox tb_Dept_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_ID;
    }
}