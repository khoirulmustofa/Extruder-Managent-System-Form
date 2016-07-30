namespace ExtruderManagementSystem_UI
{
    partial class FormLogin
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
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswords = new System.Windows.Forms.TextBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(221, 90);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(201, 26);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.Tag = "";
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(128, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txtPasswords
            // 
            this.txtPasswords.Location = new System.Drawing.Point(221, 135);
            this.txtPasswords.Name = "txtPasswords";
            this.txtPasswords.Size = new System.Drawing.Size(201, 26);
            this.txtPasswords.TabIndex = 1;
            this.txtPasswords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPasswords.UseSystemPasswordChar = true;
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.Lime;
            this.btnMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasuk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMasuk.FlatAppearance.BorderSize = 0;
            this.btnMasuk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMasuk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasuk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasuk.Location = new System.Drawing.Point(132, 242);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(90, 38);
            this.btnMasuk.TabIndex = 2;
            this.btnMasuk.Text = "MASUK";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.Red;
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBatal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(332, 242);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(90, 38);
            this.btnBatal.TabIndex = 3;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ExtruderManagementSystem_UI.Properties.Resources.purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 340);
            this.ControlBox = false;
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPasswords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserID);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ..::: Login | PT Multistrada Arah Sarana Tbk :::..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswords;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnBatal;
    }
}