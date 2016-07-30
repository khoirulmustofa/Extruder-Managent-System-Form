namespace ExtruderManagementSystem_UI.Extruder
{
    partial class FormOrderTreadBelakang
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
            this.btnBackHome = new System.Windows.Forms.Button();
            this.btnRefress = new System.Windows.Forms.Button();
            this.gvOrderTreadBelakang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSiftGroup = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderTreadBelakang)).BeginInit();
            this.SuspendLayout();
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
            this.btnBackHome.TabIndex = 26;
            this.btnBackHome.Text = "HOME";
            this.btnBackHome.UseVisualStyleBackColor = false;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // btnRefress
            // 
            this.btnRefress.BackColor = System.Drawing.Color.Blue;
            this.btnRefress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefress.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnRefress.FlatAppearance.BorderSize = 0;
            this.btnRefress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnRefress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRefress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefress.ForeColor = System.Drawing.Color.White;
            this.btnRefress.Location = new System.Drawing.Point(12, 78);
            this.btnRefress.Name = "btnRefress";
            this.btnRefress.Size = new System.Drawing.Size(88, 33);
            this.btnRefress.TabIndex = 31;
            this.btnRefress.Text = "REFRESS";
            this.btnRefress.UseVisualStyleBackColor = false;
            // 
            // gvOrderTreadBelakang
            // 
            this.gvOrderTreadBelakang.BackgroundColor = System.Drawing.Color.White;
            this.gvOrderTreadBelakang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderTreadBelakang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvOrderTreadBelakang.GridColor = System.Drawing.Color.Black;
            this.gvOrderTreadBelakang.Location = new System.Drawing.Point(0, 117);
            this.gvOrderTreadBelakang.Name = "gvOrderTreadBelakang";
            this.gvOrderTreadBelakang.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvOrderTreadBelakang.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.gvOrderTreadBelakang.RowTemplate.Height = 30;
            this.gvOrderTreadBelakang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrderTreadBelakang.Size = new System.Drawing.Size(1344, 573);
            this.gvOrderTreadBelakang.TabIndex = 32;
            this.gvOrderTreadBelakang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrderTreadBelakang_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Sift Group";
            // 
            // lblSiftGroup
            // 
            this.lblSiftGroup.AutoSize = true;
            this.lblSiftGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblSiftGroup.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiftGroup.ForeColor = System.Drawing.Color.Transparent;
            this.lblSiftGroup.Location = new System.Drawing.Point(94, 43);
            this.lblSiftGroup.Name = "lblSiftGroup";
            this.lblSiftGroup.Size = new System.Drawing.Size(17, 20);
            this.lblSiftGroup.TabIndex = 63;
            this.lblSiftGroup.Text = "+";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(380, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(17, 20);
            this.lblDescription.TabIndex = 61;
            this.lblDescription.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Sebagai";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.Transparent;
            this.lblUserName.Location = new System.Drawing.Point(94, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(17, 20);
            this.lblUserName.TabIndex = 59;
            this.lblUserName.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "User Name";
            // 
            // FormOrderTreadBelakang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::ExtruderManagementSystem_UI.Properties.Resources.purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 690);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSiftGroup);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gvOrderTreadBelakang);
            this.Controls.Add(this.btnRefress);
            this.Controls.Add(this.btnBackHome);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormOrderTreadBelakang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderTreadBelakang";
            this.Load += new System.EventHandler(this.FormOrderTreadBelakang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderTreadBelakang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Button btnRefress;
        private System.Windows.Forms.DataGridView gvOrderTreadBelakang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSiftGroup;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label5;
    }
}