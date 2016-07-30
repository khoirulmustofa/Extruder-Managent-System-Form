namespace ExtruderManagementSystem_UI.Report
{
    partial class FormReportUsedCoumpoundTread
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
            this.label7 = new System.Windows.Forms.Label();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKode_Size_Tread = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rvUsedCompdTread = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSiftGroup = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(431, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(491, 31);
            this.label7.TabIndex = 85;
            this.label7.Text = "REPORT USED COUMPOUND BY KODE SIZE";
            // 
            // dtFinish
            // 
            this.dtFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFinish.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFinish.Location = new System.Drawing.Point(694, 19);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(255, 26);
            this.dtFinish.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(629, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 73;
            this.label6.Text = "SAMPAI";
            // 
            // dtStart
            // 
            this.dtStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtStart.Location = new System.Drawing.Point(368, 17);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(255, 26);
            this.dtStart.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(251, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "TANGGAL MULAI";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(964, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 33);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "CARI";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKode_Size_Tread
            // 
            this.txtKode_Size_Tread.Location = new System.Drawing.Point(92, 19);
            this.txtKode_Size_Tread.Name = "txtKode_Size_Tread";
            this.txtKode_Size_Tread.Size = new System.Drawing.Size(100, 26);
            this.txtKode_Size_Tread.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "KODE SIZE";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtFinish);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtKode_Size_Tread);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1316, 59);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // rvUsedCompdTread
            // 
            this.rvUsedCompdTread.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rvUsedCompdTread.Location = new System.Drawing.Point(0, 166);
            this.rvUsedCompdTread.Name = "rvUsedCompdTread";
            this.rvUsedCompdTread.Size = new System.Drawing.Size(1344, 524);
            this.rvUsedCompdTread.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Sift Group";
            // 
            // lblSiftGroup
            // 
            this.lblSiftGroup.AutoSize = true;
            this.lblSiftGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblSiftGroup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiftGroup.ForeColor = System.Drawing.Color.White;
            this.lblSiftGroup.Location = new System.Drawing.Point(94, 39);
            this.lblSiftGroup.Name = "lblSiftGroup";
            this.lblSiftGroup.Size = new System.Drawing.Size(17, 20);
            this.lblSiftGroup.TabIndex = 82;
            this.lblSiftGroup.Text = "+";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(380, 5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(17, 20);
            this.lblDescription.TabIndex = 80;
            this.lblDescription.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Sebagai";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(94, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(17, 20);
            this.lblUserName.TabIndex = 78;
            this.lblUserName.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "User Name";
            // 
            // btnBackHome
            // 
            this.btnBackHome.BackColor = System.Drawing.Color.Yellow;
            this.btnBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackHome.FlatAppearance.BorderSize = 0;
            this.btnBackHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnBackHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.Location = new System.Drawing.Point(1244, 12);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(88, 33);
            this.btnBackHome.TabIndex = 76;
            this.btnBackHome.Text = "HOME";
            this.btnBackHome.UseVisualStyleBackColor = false;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // FormReportUsedCoumpoundTread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::ExtruderManagementSystem_UI.Properties.Resources.purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 690);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rvUsedCompdTread);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSiftGroup);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBackHome);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormReportUsedCoumpoundTread";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportUsedCoumpoundTread";
            this.Load += new System.EventHandler(this.FormReportUsedCoumpoundTread_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtFinish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKode_Size_Tread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rvUsedCompdTread;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSiftGroup;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackHome;

    }
}