namespace frm_User_Control_Add_Table
{
    partial class frm_Add_Bill
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
            this.btn_Add_New_Table = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_Add_New_Table
            // 
            this.btn_Add_New_Table.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add_New_Table.BackColor = System.Drawing.Color.Snow;
            this.btn_Add_New_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Table.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Table.Location = new System.Drawing.Point(460, 12);
            this.btn_Add_New_Table.Name = "btn_Add_New_Table";
            this.btn_Add_New_Table.Size = new System.Drawing.Size(157, 45);
            this.btn_Add_New_Table.TabIndex = 7;
            this.btn_Add_New_Table.Text = "Add New Table";
            this.btn_Add_New_Table.UseVisualStyleBackColor = false;
            this.btn_Add_New_Table.Click += new System.EventHandler(this.btn_Add_New_Table_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Add_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1055, 554);
            this.Controls.Add(this.btn_Add_New_Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Bill";
            this.Opacity = 0D;
            this.Text = "frm_Add_Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_New_Table;
        private System.Windows.Forms.Timer timer1;
    }
}