namespace Employee_Management_System
{
    partial class frm_View_Employee_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_View_Employee_List = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeList02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Management_02_DBDataSet = new Employee_Management_System.Emp_Management_02_DBDataSet();
            this.employeeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Mgt_02_DBDataSet3 = new Employee_Management_System.Emp_Mgt_02_DBDataSet3();
            this.employee_ListTableAdapter = new Employee_Management_System.Emp_Mgt_02_DBDataSet3TableAdapters.Employee_ListTableAdapter();
            this.empList02BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Mgt_02_DBDataSet2 = new Employee_Management_System.Emp_Mgt_02_DBDataSet2();
            this.empList02BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Mgt_02_DBDataSet1 = new Employee_Management_System.Emp_Mgt_02_DBDataSet1();
            this.empList02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emp_Mgt_02_DBDataSet = new Employee_Management_System.Emp_Mgt_02_DBDataSet();
            this.emp_List_02TableAdapter = new Employee_Management_System.Emp_Mgt_02_DBDataSetTableAdapters.Emp_List_02TableAdapter();
            this.emp_List_02TableAdapter1 = new Employee_Management_System.Emp_Mgt_02_DBDataSet1TableAdapters.Emp_List_02TableAdapter();
            this.emp_List_02TableAdapter2 = new Employee_Management_System.Emp_Mgt_02_DBDataSet2TableAdapters.Emp_List_02TableAdapter();
            this.btn_Close = new System.Windows.Forms.Button();
            this.employee_List_02TableAdapter = new Employee_Management_System.Emp_Management_02_DBDataSetTableAdapters.Employee_List_02TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Management_02_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList02BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList02BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Employee_List
            // 
            this.lbl_View_Employee_List.AutoSize = true;
            this.lbl_View_Employee_List.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Employee_List.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_View_Employee_List.Location = new System.Drawing.Point(239, 9);
            this.lbl_View_Employee_List.Name = "lbl_View_Employee_List";
            this.lbl_View_Employee_List.Size = new System.Drawing.Size(498, 62);
            this.lbl_View_Employee_List.TabIndex = 2;
            this.lbl_View_Employee_List.Text = "View Employee List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeList02BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(999, 452);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeList02BindingSource
            // 
            this.employeeList02BindingSource.DataMember = "Employee_List_02";
            this.employeeList02BindingSource.DataSource = this.emp_Management_02_DBDataSet;
            // 
            // emp_Management_02_DBDataSet
            // 
            this.emp_Management_02_DBDataSet.DataSetName = "Emp_Management_02_DBDataSet";
            this.emp_Management_02_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeListBindingSource
            // 
            this.employeeListBindingSource.DataMember = "Employee_List";
            this.employeeListBindingSource.DataSource = this.emp_Mgt_02_DBDataSet3;
            // 
            // emp_Mgt_02_DBDataSet3
            // 
            this.emp_Mgt_02_DBDataSet3.DataSetName = "Emp_Mgt_02_DBDataSet3";
            this.emp_Mgt_02_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_ListTableAdapter
            // 
            this.employee_ListTableAdapter.ClearBeforeFill = true;
            // 
            // empList02BindingSource2
            // 
            this.empList02BindingSource2.DataMember = "Emp_List_02";
            this.empList02BindingSource2.DataSource = this.emp_Mgt_02_DBDataSet2;
            // 
            // emp_Mgt_02_DBDataSet2
            // 
            this.emp_Mgt_02_DBDataSet2.DataSetName = "Emp_Mgt_02_DBDataSet2";
            this.emp_Mgt_02_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empList02BindingSource1
            // 
            this.empList02BindingSource1.DataMember = "Emp_List_02";
            this.empList02BindingSource1.DataSource = this.emp_Mgt_02_DBDataSet1;
            // 
            // emp_Mgt_02_DBDataSet1
            // 
            this.emp_Mgt_02_DBDataSet1.DataSetName = "Emp_Mgt_02_DBDataSet1";
            this.emp_Mgt_02_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empList02BindingSource
            // 
            this.empList02BindingSource.DataMember = "Emp_List_02";
            this.empList02BindingSource.DataSource = this.emp_Mgt_02_DBDataSet;
            // 
            // emp_Mgt_02_DBDataSet
            // 
            this.emp_Mgt_02_DBDataSet.DataSetName = "Emp_Mgt_02_DBDataSet";
            this.emp_Mgt_02_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emp_List_02TableAdapter
            // 
            this.emp_List_02TableAdapter.ClearBeforeFill = true;
            // 
            // emp_List_02TableAdapter1
            // 
            this.emp_List_02TableAdapter1.ClearBeforeFill = true;
            // 
            // emp_List_02TableAdapter2
            // 
            this.emp_List_02TableAdapter2.ClearBeforeFill = true;
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(458, 572);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(113, 43);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // employee_List_02TableAdapter
            // 
            this.employee_List_02TableAdapter.ClearBeforeFill = true;
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1081, 654);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_View_Employee_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_View_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employee List";
            this.Load += new System.EventHandler(this.frm_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Management_02_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList02BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList02BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empList02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_Mgt_02_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Employee_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Emp_Mgt_02_DBDataSet emp_Mgt_02_DBDataSet;
        private System.Windows.Forms.BindingSource empList02BindingSource;
        private Emp_Mgt_02_DBDataSetTableAdapters.Emp_List_02TableAdapter emp_List_02TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private Emp_Mgt_02_DBDataSet1 emp_Mgt_02_DBDataSet1;
        private System.Windows.Forms.BindingSource empList02BindingSource1;
        private Emp_Mgt_02_DBDataSet1TableAdapters.Emp_List_02TableAdapter emp_List_02TableAdapter1;
        private Emp_Mgt_02_DBDataSet2 emp_Mgt_02_DBDataSet2;
        private System.Windows.Forms.BindingSource empList02BindingSource2;
        private Emp_Mgt_02_DBDataSet2TableAdapters.Emp_List_02TableAdapter emp_List_02TableAdapter2;
        private Emp_Mgt_02_DBDataSet3 emp_Mgt_02_DBDataSet3;
        private System.Windows.Forms.BindingSource employeeListBindingSource;
        private Emp_Mgt_02_DBDataSet3TableAdapters.Employee_ListTableAdapter employee_ListTableAdapter;
        private System.Windows.Forms.Button btn_Close;
        private Emp_Management_02_DBDataSet emp_Management_02_DBDataSet;
        private System.Windows.Forms.BindingSource employeeList02BindingSource;
        private Emp_Management_02_DBDataSetTableAdapters.Employee_List_02TableAdapter employee_List_02TableAdapter;
    }
}