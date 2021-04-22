namespace Employee_Mgt_04
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Dept = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.emp_Mgt_04_DBDataSet1 = new Employee_Mgt_04.Emp_Mgt_04_DBDataSet1();
            this.deptListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dept_ListTableAdapter = new Employee_Mgt_04.Emp_Mgt_04_DBDataSet1TableAdapters.Dept_ListTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_04_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 81);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Header.Location = new System.Drawing.Point(328, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(442, 62);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = "Search Employee";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Close.Location = new System.Drawing.Point(752, 660);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(130, 46);
            this.btn_Close.TabIndex = 36;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(507, 482);
            this.cmb_Department.MaxDropDownItems = 4;
            this.cmb_Department.MaxLength = 30;
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(431, 39);
            this.cmb_Department.TabIndex = 28;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CalendarFont = new System.Drawing.Font("Modern No. 20", 18F);
            this.dtp_DOB.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.dtp_DOB.Location = new System.Drawing.Point(507, 393);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(431, 40);
            this.dtp_DOB.TabIndex = 27;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(507, 570);
            this.tb_Salary.MaxLength = 10;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(431, 40);
            this.tb_Salary.TabIndex = 26;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(507, 299);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(431, 40);
            this.tb_Mob_No.TabIndex = 25;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(507, 205);
            this.tb_Name.MaxLength = 40;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(431, 40);
            this.tb_Name.TabIndex = 24;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Char);
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_ID.Location = new System.Drawing.Point(467, 104);
            this.tb_Emp_ID.MaxLength = 4;
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(286, 40);
            this.tb_Emp_ID.TabIndex = 23;
            this.tb_Emp_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Salary.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Salary.Location = new System.Drawing.Point(221, 576);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(92, 31);
            this.lbl_Salary.TabIndex = 31;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Dept
            // 
            this.lbl_Dept.AutoSize = true;
            this.lbl_Dept.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Dept.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Dept.Location = new System.Drawing.Point(221, 485);
            this.lbl_Dept.Name = "lbl_Dept";
            this.lbl_Dept.Size = new System.Drawing.Size(158, 31);
            this.lbl_Dept.TabIndex = 32;
            this.lbl_Dept.Text = "Department";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_DOB.Location = new System.Drawing.Point(221, 399);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(184, 31);
            this.lbl_DOB.TabIndex = 34;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Mob_No.Location = new System.Drawing.Point(221, 307);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(108, 31);
            this.lbl_Mob_No.TabIndex = 35;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Name.Location = new System.Drawing.Point(221, 208);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(84, 31);
            this.lbl_Name.TabIndex = 33;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Emp_ID
            // 
            this.lbl_Emp_ID.AutoSize = true;
            this.lbl_Emp_ID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Emp_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_ID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Emp_ID.Location = new System.Drawing.Point(311, 107);
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            this.lbl_Emp_ID.Size = new System.Drawing.Size(114, 31);
            this.lbl_Emp_ID.TabIndex = 30;
            this.lbl_Emp_ID.Text = "Emp ID";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Search.Location = new System.Drawing.Point(811, 98);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(162, 46);
            this.btn_Search.TabIndex = 29;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Update.Location = new System.Drawing.Point(202, 660);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(154, 46);
            this.btn_Update.TabIndex = 29;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Refresh.Location = new System.Drawing.Point(467, 660);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(179, 46);
            this.btn_Refresh.TabIndex = 29;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // emp_Mgt_04_DBDataSet1
            // 
            this.emp_Mgt_04_DBDataSet1.DataSetName = "Emp_Mgt_04_DBDataSet1";
            this.emp_Mgt_04_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deptListBindingSource
            // 
            this.deptListBindingSource.DataMember = "Dept_List";
            this.deptListBindingSource.DataSource = this.emp_Mgt_04_DBDataSet1;
            // 
            // dept_ListTableAdapter
            // 
            this.dept_ListTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Search_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1168, 739);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Emp_ID);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Dept);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Emp_ID);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Search_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Search_Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_04_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Dept;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
        private Emp_Mgt_04_DBDataSet1 emp_Mgt_04_DBDataSet1;
        private System.Windows.Forms.BindingSource deptListBindingSource;
        private Emp_Mgt_04_DBDataSet1TableAdapters.Dept_ListTableAdapter dept_ListTableAdapter;
    }
}