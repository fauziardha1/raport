namespace raport
{
    partial class IdenKepsek
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
			this.btnIdenKepSek = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboGender = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSavekepsek = new System.Windows.Forms.Button();
			this.nipKepsek = new System.Windows.Forms.TextBox();
			this.namaKepsek = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.ForestGreen;
			this.panel1.Controls.Add(this.btnIdenKepSek);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(950, 50);
			this.panel1.TabIndex = 6;
			// 
			// btnIdenKepSek
			// 
			this.btnIdenKepSek.FlatAppearance.BorderSize = 0;
			this.btnIdenKepSek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnIdenKepSek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIdenKepSek.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIdenKepSek.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnIdenKepSek.Image = global::raport.Properties.Resources.kepsek;
			this.btnIdenKepSek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIdenKepSek.Location = new System.Drawing.Point(269, 3);
			this.btnIdenKepSek.Name = "btnIdenKepSek";
			this.btnIdenKepSek.Size = new System.Drawing.Size(403, 40);
			this.btnIdenKepSek.TabIndex = 5;
			this.btnIdenKepSek.Text = "IDENTITAS KEPALA SEKOLAH";
			this.btnIdenKepSek.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboGender);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnSavekepsek);
			this.groupBox1.Controls.Add(this.nipKepsek);
			this.groupBox1.Controls.Add(this.namaKepsek);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(25, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(901, 213);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Identitas Kepala Sekolah";
			// 
			// comboGender
			// 
			this.comboGender.FormattingEnabled = true;
			this.comboGender.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
			this.comboGender.Location = new System.Drawing.Point(200, 122);
			this.comboGender.Name = "comboGender";
			this.comboGender.Size = new System.Drawing.Size(183, 29);
			this.comboGender.TabIndex = 25;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 21);
			this.label3.TabIndex = 24;
			this.label3.Text = "JENIS KELAMIN";
			// 
			// btnSavekepsek
			// 
			this.btnSavekepsek.Location = new System.Drawing.Point(733, 44);
			this.btnSavekepsek.Name = "btnSavekepsek";
			this.btnSavekepsek.Size = new System.Drawing.Size(121, 39);
			this.btnSavekepsek.TabIndex = 22;
			this.btnSavekepsek.Text = "SIMPAN";
			this.btnSavekepsek.UseVisualStyleBackColor = true;
			this.btnSavekepsek.Click += new System.EventHandler(this.btnSavekepsek_Click);
			// 
			// nipKepsek
			// 
			this.nipKepsek.Location = new System.Drawing.Point(200, 84);
			this.nipKepsek.Name = "nipKepsek";
			this.nipKepsek.Size = new System.Drawing.Size(500, 27);
			this.nipKepsek.TabIndex = 13;
			// 
			// namaKepsek
			// 
			this.namaKepsek.Location = new System.Drawing.Point(200, 44);
			this.namaKepsek.Name = "namaKepsek";
			this.namaKepsek.Size = new System.Drawing.Size(500, 27);
			this.namaKepsek.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "NAMA";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "NIP";
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.AutoSize = true;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(951, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(20, 20);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "X";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// IdenKepsek
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(973, 330);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "IdenKepsek";
			this.Text = "IdenKepsek";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIdenKepSek;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSavekepsek;
        private System.Windows.Forms.TextBox nipKepsek;
        private System.Windows.Forms.TextBox namaKepsek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.ComboBox comboGender;
    }
}