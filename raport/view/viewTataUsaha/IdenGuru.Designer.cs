namespace raport
{
    partial class IdenGuru
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
			this.btnIdenGuru = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboKelas = new System.Windows.Forms.ComboBox();
			this.comboGender = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.nipGuru = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.namaGuru = new System.Windows.Forms.TextBox();
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
			this.panel1.Controls.Add(this.btnIdenGuru);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(950, 50);
			this.panel1.TabIndex = 0;
			// 
			// btnIdenGuru
			// 
			this.btnIdenGuru.FlatAppearance.BorderSize = 0;
			this.btnIdenGuru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnIdenGuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIdenGuru.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIdenGuru.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnIdenGuru.Image = global::raport.Properties.Resources.guru;
			this.btnIdenGuru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIdenGuru.Location = new System.Drawing.Point(318, 7);
			this.btnIdenGuru.Name = "btnIdenGuru";
			this.btnIdenGuru.Size = new System.Drawing.Size(278, 40);
			this.btnIdenGuru.TabIndex = 6;
			this.btnIdenGuru.Text = "IDENTITAS GURU";
			this.btnIdenGuru.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboKelas);
			this.groupBox1.Controls.Add(this.comboGender);
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.nipGuru);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.namaGuru);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(25, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(901, 222);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Identitas Guru";
			// 
			// comboKelas
			// 
			this.comboKelas.FormattingEnabled = true;
			this.comboKelas.Items.AddRange(new object[] {
            "KELAS I",
            "KELAS I-A",
            "KELAS I-B",
            "KELAS II",
            "KELAS II-A",
            "KELAS II-B",
            "KELAS III",
            "KELAS III-A",
            "KELAS III-B",
            "KELAS IV",
            "KELAS IV-A",
            "KELAS IV-B",
            "KELAS V",
            "KELAS V-A",
            "KELAS V-B",
            "KELAS VI",
            "KELAS VI-A",
            "KELAS VI-B",
            "AGAMA",
            "OLAH RAGA"});
			this.comboKelas.Location = new System.Drawing.Point(250, 162);
			this.comboKelas.Name = "comboKelas";
			this.comboKelas.Size = new System.Drawing.Size(209, 29);
			this.comboKelas.TabIndex = 25;
			this.comboKelas.SelectedIndexChanged += new System.EventHandler(this.comboKelas_SelectedIndexChanged);
			// 
			// comboGender
			// 
			this.comboGender.FormattingEnabled = true;
			this.comboGender.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
			this.comboGender.Location = new System.Drawing.Point(250, 122);
			this.comboGender.Name = "comboGender";
			this.comboGender.Size = new System.Drawing.Size(209, 29);
			this.comboGender.TabIndex = 24;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(733, 44);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(121, 39);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "SIMPAN";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// nipGuru
			// 
			this.nipGuru.Location = new System.Drawing.Point(250, 84);
			this.nipGuru.Name = "nipGuru";
			this.nipGuru.Size = new System.Drawing.Size(450, 27);
			this.nipGuru.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(210, 21);
			this.label4.TabIndex = 12;
			this.label4.Text = "KELAS/MATA PELAJARAN";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 21);
			this.label3.TabIndex = 11;
			this.label3.Text = "JENIS KELAMIN";
			// 
			// namaGuru
			// 
			this.namaGuru.Location = new System.Drawing.Point(250, 44);
			this.namaGuru.Name = "namaGuru";
			this.namaGuru.Size = new System.Drawing.Size(450, 27);
			this.namaGuru.TabIndex = 10;
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
			this.btnClose.Location = new System.Drawing.Point(954, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(20, 20);
			this.btnClose.TabIndex = 11;
			this.btnClose.Text = "X";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// IdenGuru
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(975, 324);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "IdenGuru";
			this.Text = "IdenGuru";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIdenGuru;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox nipGuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namaGuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.ComboBox comboKelas;
        private System.Windows.Forms.ComboBox comboGender;
    }
}