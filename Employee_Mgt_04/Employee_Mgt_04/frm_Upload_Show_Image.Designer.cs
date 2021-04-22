namespace Employee_Mgt_04
{
    partial class frm_Upload_Show_Image
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
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.pb_Show_Image = new System.Windows.Forms.PictureBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.tb_Image_ID = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Show_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.lbl_Header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 81);
            this.panel1.TabIndex = 5;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Elephant", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Header.Location = new System.Drawing.Point(261, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(605, 62);
            this.lbl_Header.TabIndex = 13;
            this.lbl_Header.Text = "Image Upload and Show";
            // 
            // pb_Image
            // 
            this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Image.Location = new System.Drawing.Point(64, 175);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(360, 314);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 6;
            this.pb_Image.TabStop = false;
            // 
            // pb_Show_Image
            // 
            this.pb_Show_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Show_Image.Location = new System.Drawing.Point(703, 175);
            this.pb_Show_Image.Name = "pb_Show_Image";
            this.pb_Show_Image.Size = new System.Drawing.Size(360, 314);
            this.pb_Show_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Show_Image.TabIndex = 6;
            this.pb_Show_Image.TabStop = false;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Browse.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Browse.Location = new System.Drawing.Point(64, 511);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(162, 46);
            this.btn_Browse.TabIndex = 31;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Upload.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Upload.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Upload.Location = new System.Drawing.Point(262, 511);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(162, 46);
            this.btn_Upload.TabIndex = 31;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Show.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Show.Location = new System.Drawing.Point(703, 511);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(162, 46);
            this.btn_Show.TabIndex = 31;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // tb_Image_ID
            // 
            this.tb_Image_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Image_ID.Location = new System.Drawing.Point(892, 511);
            this.tb_Image_ID.MaxLength = 40;
            this.tb_Image_ID.Name = "tb_Image_ID";
            this.tb_Image_ID.Size = new System.Drawing.Size(171, 40);
            this.tb_Image_ID.TabIndex = 32;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Close.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.SpringGreen;
            this.btn_Close.Location = new System.Drawing.Point(1050, 638);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(128, 46);
            this.btn_Close.TabIndex = 33;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // frm_Upload_Show_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1190, 696);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tb_Image_ID);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.btn_Upload);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.pb_Show_Image);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Upload_Show_Image";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Show_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.PictureBox pb_Show_Image;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.TextBox tb_Image_ID;
        private System.Windows.Forms.Button btn_Close;
    }
}