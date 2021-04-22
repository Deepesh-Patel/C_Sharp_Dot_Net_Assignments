namespace Employee_Mgt_04
{
    partial class frm_View_Emp_Details_By_Dept
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
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.lbl_Dept = new System.Windows.Forms.Label();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh_Grid = new System.Windows.Forms.Button();
            this.dgv_Emp_Details = new System.Windows.Forms.DataGridView();
            this.empList4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Mgt_04_DBDataSet3 = new Employee_Mgt_04.Emp_Mgt_04_DBDataSet3();
            this.emp_List_4TableAdapter = new Employee_Mgt_04.Emp_Mgt_04_DBDataSet3TableAdapters.Emp_List_4TableAdapter();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_04_DBDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 81);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Header.Location = new System.Drawing.Point(392, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(573, 62);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = "View Employee Details";
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Modern No. 20", 18F);
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Location = new System.Drawing.Point(325, 121);
            this.cmb_Department.MaxDropDownItems = 4;
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(286, 39);
            this.cmb_Department.TabIndex = 17;
            this.cmb_Department.SelectedIndexChanged += new System.EventHandler(this.Load_Employee_Data);
            // 
            // lbl_Dept
            // 
            this.lbl_Dept.AutoSize = true;
            this.lbl_Dept.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Dept.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dept.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Dept.Location = new System.Drawing.Point(123, 124);
            this.lbl_Dept.Name = "lbl_Dept";
            this.lbl_Dept.Size = new System.Drawing.Size(158, 31);
            this.lbl_Dept.TabIndex = 18;
            this.lbl_Dept.Text = "Department";
            // 
            // lbl_Emp_ID
            // 
            this.lbl_Emp_ID.AutoSize = true;
            this.lbl_Emp_ID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Emp_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_ID.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Emp_ID.Location = new System.Drawing.Point(123, 189);
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            this.lbl_Emp_ID.Size = new System.Drawing.Size(114, 31);
            this.lbl_Emp_ID.TabIndex = 19;
            this.lbl_Emp_ID.Text = "Emp ID";
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_ID.Location = new System.Drawing.Point(325, 186);
            this.tb_Emp_ID.MaxLength = 40;
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(286, 40);
            this.tb_Emp_ID.TabIndex = 20;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Search.Location = new System.Drawing.Point(683, 178);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(162, 46);
            this.btn_Search.TabIndex = 30;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Refresh_Grid
            // 
            this.btn_Refresh_Grid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Refresh_Grid.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh_Grid.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Refresh_Grid.Location = new System.Drawing.Point(909, 178);
            this.btn_Refresh_Grid.Name = "btn_Refresh_Grid";
            this.btn_Refresh_Grid.Size = new System.Drawing.Size(281, 46);
            this.btn_Refresh_Grid.TabIndex = 30;
            this.btn_Refresh_Grid.Text = "Refresh Grid";
            this.btn_Refresh_Grid.UseVisualStyleBackColor = false;
            this.btn_Refresh_Grid.Click += new System.EventHandler(this.btn_Refresh_Grid_Click);
            // 
            // dgv_Emp_Details
            // 
            this.dgv_Emp_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Emp_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Emp_Details.Location = new System.Drawing.Point(35, 276);
            this.dgv_Emp_Details.Name = "dgv_Emp_Details";
            this.dgv_Emp_Details.RowTemplate.Height = 24;
            this.dgv_Emp_Details.Size = new System.Drawing.Size(1319, 364);
            this.dgv_Emp_Details.TabIndex = 31;
            // 
            // empList4BindingSource
            // 
            this.empList4BindingSource.DataMember = "Emp_List_4";
            this.empList4BindingSource.DataSource = this.emp_Mgt_04_DBDataSet3;
            // 
            // emp_Mgt_04_DBDataSet3
            // 
            this.emp_Mgt_04_DBDataSet3.DataSetName = "Emp_Mgt_04_DBDataSet3";
            this.emp_Mgt_04_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_List_4TableAdapter
            // 
            this.emp_List_4TableAdapter.ClearBeforeFill = true;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Close.Location = new System.Drawing.Point(1226, 660);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(128, 46);
            this.btn_Close.TabIndex = 34;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_View_Emp_Details_By_Dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1400, 718);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dgv_Emp_Details);
            this.Controls.Add(this.btn_Refresh_Grid);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Emp_ID);
            this.Controls.Add(this.lbl_Emp_ID);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.lbl_Dept);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_View_Emp_Details_By_Dept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_View_Emp_Details_By_Dept_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Emp_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_04_DBDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.Label lbl_Dept;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh_Grid;
        private System.Windows.Forms.DataGridView dgv_Emp_Details;
        private Emp_Mgt_04_DBDataSet3 emp_Mgt_04_DBDataSet3;
        private System.Windows.Forms.BindingSource empList4BindingSource;
        private Emp_Mgt_04_DBDataSet3TableAdapters.Emp_List_4TableAdapter emp_List_4TableAdapter;
        private System.Windows.Forms.Button btn_Close;
    }
}