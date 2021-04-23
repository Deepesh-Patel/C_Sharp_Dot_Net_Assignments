namespace Windows_Form_Control
{
    partial class frm_Windows_Form_Control
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
            this.gb_Input = new System.Windows.Forms.GroupBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rd_btn_Night = new System.Windows.Forms.RadioButton();
            this.rd_btn_Evening = new System.Windows.Forms.RadioButton();
            this.rd_btn_Morning = new System.Windows.Forms.RadioButton();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rd_btn_Female = new System.Windows.Forms.RadioButton();
            this.rd_btn_Male = new System.Windows.Forms.RadioButton();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift_Timing = new System.Windows.Forms.Label();
            this.lbl_Shift_Note = new System.Windows.Forms.Label();
            this.lbl_Gender_Note = new System.Windows.Forms.Label();
            this.lbl_Name_Note = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.gb_Output = new System.Windows.Forms.GroupBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gb_Input.SuspendLayout();
            this.gb_Shift_Time.SuspendLayout();
            this.gb_Gender.SuspendLayout();
            this.gb_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 67);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Algerian", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(494, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(549, 49);
            this.lbl_Header.TabIndex = 0;
            this.lbl_Header.Text = "Windows Form Controls";
            // 
            // gb_Input
            // 
            this.gb_Input.Controls.Add(this.btn_Submit);
            this.gb_Input.Controls.Add(this.btn_Refresh);
            this.gb_Input.Controls.Add(this.gb_Shift_Time);
            this.gb_Input.Controls.Add(this.gb_Gender);
            this.gb_Input.Controls.Add(this.tb_Name);
            this.gb_Input.Controls.Add(this.lbl_Gender);
            this.gb_Input.Controls.Add(this.lbl_Shift_Timing);
            this.gb_Input.Controls.Add(this.lbl_Shift_Note);
            this.gb_Input.Controls.Add(this.lbl_Gender_Note);
            this.gb_Input.Controls.Add(this.lbl_Name_Note);
            this.gb_Input.Controls.Add(this.lbl_Name);
            this.gb_Input.Location = new System.Drawing.Point(23, 91);
            this.gb_Input.Name = "gb_Input";
            this.gb_Input.Size = new System.Drawing.Size(1460, 439);
            this.gb_Input.TabIndex = 1;
            this.gb_Input.TabStop = false;
            this.gb_Input.Text = "Input";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Snow;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(851, 359);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(127, 54);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Snow;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(444, 359);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(127, 54);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.Controls.Add(this.rd_btn_Night);
            this.gb_Shift_Time.Controls.Add(this.rd_btn_Evening);
            this.gb_Shift_Time.Controls.Add(this.rd_btn_Morning);
            this.gb_Shift_Time.Location = new System.Drawing.Point(1022, 42);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(194, 178);
            this.gb_Shift_Time.TabIndex = 3;
            this.gb_Shift_Time.TabStop = false;
            // 
            // rd_btn_Night
            // 
            this.rd_btn_Night.AutoSize = true;
            this.rd_btn_Night.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Night.Location = new System.Drawing.Point(33, 133);
            this.rd_btn_Night.Name = "rd_btn_Night";
            this.rd_btn_Night.Size = new System.Drawing.Size(88, 29);
            this.rd_btn_Night.TabIndex = 0;
            this.rd_btn_Night.TabStop = true;
            this.rd_btn_Night.Text = "Night";
            this.rd_btn_Night.UseVisualStyleBackColor = true;
            this.rd_btn_Night.CheckedChanged += new System.EventHandler(this.Shift_Time_Checked_Change);
            // 
            // rd_btn_Evening
            // 
            this.rd_btn_Evening.AutoSize = true;
            this.rd_btn_Evening.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Evening.Location = new System.Drawing.Point(33, 74);
            this.rd_btn_Evening.Name = "rd_btn_Evening";
            this.rd_btn_Evening.Size = new System.Drawing.Size(114, 29);
            this.rd_btn_Evening.TabIndex = 0;
            this.rd_btn_Evening.TabStop = true;
            this.rd_btn_Evening.Text = "Evening";
            this.rd_btn_Evening.UseVisualStyleBackColor = true;
            this.rd_btn_Evening.CheckedChanged += new System.EventHandler(this.Shift_Time_Checked_Change);
            // 
            // rd_btn_Morning
            // 
            this.rd_btn_Morning.AutoSize = true;
            this.rd_btn_Morning.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Morning.Location = new System.Drawing.Point(33, 21);
            this.rd_btn_Morning.Name = "rd_btn_Morning";
            this.rd_btn_Morning.Size = new System.Drawing.Size(118, 29);
            this.rd_btn_Morning.TabIndex = 0;
            this.rd_btn_Morning.TabStop = true;
            this.rd_btn_Morning.Text = "Morning";
            this.rd_btn_Morning.UseVisualStyleBackColor = true;
            this.rd_btn_Morning.CheckedChanged += new System.EventHandler(this.Shift_Time_Checked_Change);
            // 
            // gb_Gender
            // 
            this.gb_Gender.Controls.Add(this.rd_btn_Female);
            this.gb_Gender.Controls.Add(this.rd_btn_Male);
            this.gb_Gender.Location = new System.Drawing.Point(249, 207);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(439, 71);
            this.gb_Gender.TabIndex = 2;
            this.gb_Gender.TabStop = false;
            // 
            // rd_btn_Female
            // 
            this.rd_btn_Female.AutoSize = true;
            this.rd_btn_Female.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Female.Location = new System.Drawing.Point(272, 22);
            this.rd_btn_Female.Name = "rd_btn_Female";
            this.rd_btn_Female.Size = new System.Drawing.Size(105, 29);
            this.rd_btn_Female.TabIndex = 0;
            this.rd_btn_Female.Text = "Female";
            this.rd_btn_Female.UseVisualStyleBackColor = true;
            this.rd_btn_Female.CheckedChanged += new System.EventHandler(this.Gender_Checked_Change);
            // 
            // rd_btn_Male
            // 
            this.rd_btn_Male.AutoSize = true;
            this.rd_btn_Male.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Male.Location = new System.Drawing.Point(46, 22);
            this.rd_btn_Male.Name = "rd_btn_Male";
            this.rd_btn_Male.Size = new System.Drawing.Size(83, 29);
            this.rd_btn_Male.TabIndex = 0;
            this.rd_btn_Male.Text = "Male";
            this.rd_btn_Male.UseVisualStyleBackColor = true;
            this.rd_btn_Male.CheckedChanged += new System.EventHandler(this.Gender_Checked_Change);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(249, 59);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(439, 29);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(89, 226);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(104, 31);
            this.lbl_Gender.TabIndex = 0;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Shift_Timing
            // 
            this.lbl_Shift_Timing.AutoSize = true;
            this.lbl_Shift_Timing.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Timing.Location = new System.Drawing.Point(862, 55);
            this.lbl_Shift_Timing.Name = "lbl_Shift_Timing";
            this.lbl_Shift_Timing.Size = new System.Drawing.Size(140, 31);
            this.lbl_Shift_Timing.TabIndex = 0;
            this.lbl_Shift_Timing.Text = "Shift Time";
            // 
            // lbl_Shift_Note
            // 
            this.lbl_Shift_Note.AutoSize = true;
            this.lbl_Shift_Note.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Shift_Note.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Note.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Shift_Note.Location = new System.Drawing.Point(1028, 223);
            this.lbl_Shift_Note.Name = "lbl_Shift_Note";
            this.lbl_Shift_Note.Size = new System.Drawing.Size(93, 24);
            this.lbl_Shift_Note.TabIndex = 0;
            this.lbl_Shift_Note.Text = "Shift Note";
            // 
            // lbl_Gender_Note
            // 
            this.lbl_Gender_Note.AutoSize = true;
            this.lbl_Gender_Note.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Gender_Note.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender_Note.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Gender_Note.Location = new System.Drawing.Point(495, 281);
            this.lbl_Gender_Note.Name = "lbl_Gender_Note";
            this.lbl_Gender_Note.Size = new System.Drawing.Size(118, 24);
            this.lbl_Gender_Note.TabIndex = 0;
            this.lbl_Gender_Note.Text = "Gender Note";
            // 
            // lbl_Name_Note
            // 
            this.lbl_Name_Note.AutoSize = true;
            this.lbl_Name_Note.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_Name_Note.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name_Note.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Name_Note.Location = new System.Drawing.Point(495, 91);
            this.lbl_Name_Note.Name = "lbl_Name_Note";
            this.lbl_Name_Note.Size = new System.Drawing.Size(100, 24);
            this.lbl_Name_Note.TabIndex = 0;
            this.lbl_Name_Note.Text = "NameNote";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(89, 55);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(87, 31);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // gb_Output
            // 
            this.gb_Output.Controls.Add(this.lbl_Output);
            this.gb_Output.Controls.Add(this.tb_Output);
            this.gb_Output.Location = new System.Drawing.Point(23, 585);
            this.gb_Output.Name = "gb_Output";
            this.gb_Output.Size = new System.Drawing.Size(1460, 139);
            this.gb_Output.TabIndex = 2;
            this.gb_Output.TabStop = false;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(89, 63);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(108, 35);
            this.lbl_Output.TabIndex = 0;
            this.lbl_Output.Text = "Output";
            // 
            // tb_Output
            // 
            this.tb_Output.Enabled = false;
            this.tb_Output.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(265, 65);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(1092, 36);
            this.tb_Output.TabIndex = 1;
            // 
            // frm_Windows_Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1510, 736);
            this.Controls.Add(this.gb_Output);
            this.Controls.Add(this.gb_Input);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Windows_Form_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Windows_Form_Control";
            this.Load += new System.EventHandler(this.frm_Windows_Form_Control_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Input.ResumeLayout(false);
            this.gb_Input.PerformLayout();
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Output.ResumeLayout(false);
            this.gb_Output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.GroupBox gb_Input;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.RadioButton rd_btn_Night;
        private System.Windows.Forms.RadioButton rd_btn_Evening;
        private System.Windows.Forms.RadioButton rd_btn_Morning;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rd_btn_Female;
        private System.Windows.Forms.RadioButton rd_btn_Male;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift_Timing;
        private System.Windows.Forms.Label lbl_Shift_Note;
        private System.Windows.Forms.Label lbl_Gender_Note;
        private System.Windows.Forms.Label lbl_Name_Note;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.GroupBox gb_Output;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Output;
    }
}