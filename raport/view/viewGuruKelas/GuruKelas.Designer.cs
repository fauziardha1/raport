namespace raport
{
    partial class GuruKelas
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
			this.MenuVertical = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.BarraTitulo = new System.Windows.Forms.Panel();
			this.panelReg = new System.Windows.Forms.Panel();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnMin = new System.Windows.Forms.PictureBox();
			this.btnMax = new System.Windows.Forms.PictureBox();
			this.btnRestore = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.btnMenu = new System.Windows.Forms.PictureBox();
			this.btnCetakRaportPAS = new System.Windows.Forms.Button();
			this.btnNilaiKeterampilan = new System.Windows.Forms.Button();
			this.btnAbsensi = new System.Windows.Forms.Button();
			this.btnCetakRaportPTS = new System.Windows.Forms.Button();
			this.btnRekapNilai = new System.Windows.Forms.Button();
			this.btnNilaiSikap = new System.Windows.Forms.Button();
			this.btnNilaiPengetahuan = new System.Windows.Forms.Button();
			this.btnJumlahMurid = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MenuVertical.SuspendLayout();
			this.BarraTitulo.SuspendLayout();
			this.panelReg.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuVertical
			// 
			this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.MenuVertical.Controls.Add(this.btnCetakRaportPAS);
			this.MenuVertical.Controls.Add(this.btnNilaiKeterampilan);
			this.MenuVertical.Controls.Add(this.btnAbsensi);
			this.MenuVertical.Controls.Add(this.btnCetakRaportPTS);
			this.MenuVertical.Controls.Add(this.btnRekapNilai);
			this.MenuVertical.Controls.Add(this.btnNilaiSikap);
			this.MenuVertical.Controls.Add(this.btnNilaiPengetahuan);
			this.MenuVertical.Controls.Add(this.btnJumlahMurid);
			this.MenuVertical.Controls.Add(this.panel1);
			this.MenuVertical.Controls.Add(this.label1);
			this.MenuVertical.Controls.Add(this.pictureBox1);
			this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuVertical.Location = new System.Drawing.Point(0, 0);
			this.MenuVertical.Name = "MenuVertical";
			this.MenuVertical.Size = new System.Drawing.Size(250, 650);
			this.MenuVertical.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(0, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 1);
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "UPTD SDN 01 SUAYAN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BarraTitulo.Controls.Add(this.btnMin);
			this.BarraTitulo.Controls.Add(this.btnMax);
			this.BarraTitulo.Controls.Add(this.btnRestore);
			this.BarraTitulo.Controls.Add(this.btnClose);
			this.BarraTitulo.Controls.Add(this.btnMenu);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(1050, 45);
			this.BarraTitulo.TabIndex = 1;
			this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
			// 
			// panelReg
			// 
			this.panelReg.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelReg.Controls.Add(this.pictureBox2);
			this.panelReg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelReg.Location = new System.Drawing.Point(250, 45);
			this.panelReg.Name = "panelReg";
			this.panelReg.Size = new System.Drawing.Size(1050, 605);
			this.panelReg.TabIndex = 2;
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::raport.Properties.Resources.tutwuri;
			this.pictureBox2.Location = new System.Drawing.Point(203, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(587, 440);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// btnMin
			// 
			this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMin.Image = global::raport.Properties.Resources.btnMin;
			this.btnMin.Location = new System.Drawing.Point(979, 5);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(18, 18);
			this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnMin.TabIndex = 4;
			this.btnMin.TabStop = false;
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// btnMax
			// 
			this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMax.Image = global::raport.Properties.Resources.btnMax;
			this.btnMax.Location = new System.Drawing.Point(1003, 5);
			this.btnMax.Name = "btnMax";
			this.btnMax.Size = new System.Drawing.Size(18, 18);
			this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnMax.TabIndex = 3;
			this.btnMax.TabStop = false;
			this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRestore.Image = global::raport.Properties.Resources.btnRestore;
			this.btnRestore.Location = new System.Drawing.Point(1003, 5);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(18, 18);
			this.btnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnRestore.TabIndex = 2;
			this.btnRestore.TabStop = false;
			this.btnRestore.Visible = false;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Image = global::raport.Properties.Resources.btnClose;
			this.btnClose.Location = new System.Drawing.Point(1027, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(18, 18);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnClose.TabIndex = 1;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnMenu
			// 
			this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenu.Image = global::raport.Properties.Resources.btnMenu;
			this.btnMenu.Location = new System.Drawing.Point(5, 5);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(35, 35);
			this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMenu.TabIndex = 0;
			this.btnMenu.TabStop = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// btnCetakRaportPAS
			// 
			this.btnCetakRaportPAS.FlatAppearance.BorderSize = 0;
			this.btnCetakRaportPAS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnCetakRaportPAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCetakRaportPAS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCetakRaportPAS.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnCetakRaportPAS.Image = global::raport.Properties.Resources.graduation;
			this.btnCetakRaportPAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCetakRaportPAS.Location = new System.Drawing.Point(0, 420);
			this.btnCetakRaportPAS.Name = "btnCetakRaportPAS";
			this.btnCetakRaportPAS.Size = new System.Drawing.Size(250, 40);
			this.btnCetakRaportPAS.TabIndex = 13;
			this.btnCetakRaportPAS.Text = "Cetak Raport PAS";
			this.btnCetakRaportPAS.UseVisualStyleBackColor = true;
			// 
			// btnNilaiKeterampilan
			// 
			this.btnNilaiKeterampilan.FlatAppearance.BorderSize = 0;
			this.btnNilaiKeterampilan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnNilaiKeterampilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNilaiKeterampilan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNilaiKeterampilan.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnNilaiKeterampilan.Image = global::raport.Properties.Resources.skills;
			this.btnNilaiKeterampilan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNilaiKeterampilan.Location = new System.Drawing.Point(0, 236);
			this.btnNilaiKeterampilan.Name = "btnNilaiKeterampilan";
			this.btnNilaiKeterampilan.Size = new System.Drawing.Size(250, 40);
			this.btnNilaiKeterampilan.TabIndex = 12;
			this.btnNilaiKeterampilan.Text = "Nilai Keterampilan";
			this.btnNilaiKeterampilan.UseVisualStyleBackColor = true;
			this.btnNilaiKeterampilan.Click += new System.EventHandler(this.btnNilaiKeterampilan_Click);
			// 
			// btnAbsensi
			// 
			this.btnAbsensi.FlatAppearance.BorderSize = 0;
			this.btnAbsensi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbsensi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbsensi.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnAbsensi.Image = global::raport.Properties.Resources.presence;
			this.btnAbsensi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAbsensi.Location = new System.Drawing.Point(0, 328);
			this.btnAbsensi.Name = "btnAbsensi";
			this.btnAbsensi.Size = new System.Drawing.Size(250, 40);
			this.btnAbsensi.TabIndex = 11;
			this.btnAbsensi.Text = "Absensi";
			this.btnAbsensi.UseVisualStyleBackColor = true;
			this.btnAbsensi.Click += new System.EventHandler(this.btnAbsensi_Click);
			// 
			// btnCetakRaportPTS
			// 
			this.btnCetakRaportPTS.FlatAppearance.BorderSize = 0;
			this.btnCetakRaportPTS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnCetakRaportPTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCetakRaportPTS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCetakRaportPTS.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnCetakRaportPTS.Image = global::raport.Properties.Resources.diploma;
			this.btnCetakRaportPTS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCetakRaportPTS.Location = new System.Drawing.Point(0, 374);
			this.btnCetakRaportPTS.Name = "btnCetakRaportPTS";
			this.btnCetakRaportPTS.Size = new System.Drawing.Size(250, 40);
			this.btnCetakRaportPTS.TabIndex = 10;
			this.btnCetakRaportPTS.Text = "Cetak Raport PTS";
			this.btnCetakRaportPTS.UseVisualStyleBackColor = true;
			// 
			// btnRekapNilai
			// 
			this.btnRekapNilai.FlatAppearance.BorderSize = 0;
			this.btnRekapNilai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnRekapNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRekapNilai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRekapNilai.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnRekapNilai.Image = global::raport.Properties.Resources.recapt;
			this.btnRekapNilai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRekapNilai.Location = new System.Drawing.Point(0, 282);
			this.btnRekapNilai.Name = "btnRekapNilai";
			this.btnRekapNilai.Size = new System.Drawing.Size(250, 40);
			this.btnRekapNilai.TabIndex = 9;
			this.btnRekapNilai.Text = "Rekap Nilai";
			this.btnRekapNilai.UseVisualStyleBackColor = true;
			this.btnRekapNilai.Click += new System.EventHandler(this.btnRekapNilai_Click);
			// 
			// btnNilaiSikap
			// 
			this.btnNilaiSikap.FlatAppearance.BorderSize = 0;
			this.btnNilaiSikap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnNilaiSikap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNilaiSikap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNilaiSikap.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnNilaiSikap.Image = global::raport.Properties.Resources.sikap;
			this.btnNilaiSikap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNilaiSikap.Location = new System.Drawing.Point(0, 144);
			this.btnNilaiSikap.Name = "btnNilaiSikap";
			this.btnNilaiSikap.Size = new System.Drawing.Size(250, 40);
			this.btnNilaiSikap.TabIndex = 8;
			this.btnNilaiSikap.Text = "Nilai Sikap";
			this.btnNilaiSikap.UseVisualStyleBackColor = true;
			this.btnNilaiSikap.Click += new System.EventHandler(this.btnNilaiSikap_Click);
			// 
			// btnNilaiPengetahuan
			// 
			this.btnNilaiPengetahuan.FlatAppearance.BorderSize = 0;
			this.btnNilaiPengetahuan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnNilaiPengetahuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNilaiPengetahuan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNilaiPengetahuan.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnNilaiPengetahuan.Image = global::raport.Properties.Resources.knowledge;
			this.btnNilaiPengetahuan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNilaiPengetahuan.Location = new System.Drawing.Point(0, 190);
			this.btnNilaiPengetahuan.Name = "btnNilaiPengetahuan";
			this.btnNilaiPengetahuan.Size = new System.Drawing.Size(250, 40);
			this.btnNilaiPengetahuan.TabIndex = 7;
			this.btnNilaiPengetahuan.Text = "Nilai Pengetahuan";
			this.btnNilaiPengetahuan.UseVisualStyleBackColor = true;
			this.btnNilaiPengetahuan.Click += new System.EventHandler(this.btnNilaiPengetahuan_Click);
			// 
			// btnJumlahMurid
			// 
			this.btnJumlahMurid.FlatAppearance.BorderSize = 0;
			this.btnJumlahMurid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnJumlahMurid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnJumlahMurid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJumlahMurid.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnJumlahMurid.Image = global::raport.Properties.Resources.guru;
			this.btnJumlahMurid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnJumlahMurid.Location = new System.Drawing.Point(0, 98);
			this.btnJumlahMurid.Name = "btnJumlahMurid";
			this.btnJumlahMurid.Size = new System.Drawing.Size(250, 40);
			this.btnJumlahMurid.TabIndex = 6;
			this.btnJumlahMurid.Text = "Jumlah Murid";
			this.btnJumlahMurid.UseVisualStyleBackColor = true;
			this.btnJumlahMurid.Click += new System.EventHandler(this.btnJumlahMurid_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::raport.Properties.Resources.Icon;
			this.pictureBox1.Location = new System.Drawing.Point(5, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// GuruKelas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1300, 650);
			this.Controls.Add(this.panelReg);
			this.Controls.Add(this.BarraTitulo);
			this.Controls.Add(this.MenuVertical);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GuruKelas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "register";
			this.MenuVertical.ResumeLayout(false);
			this.MenuVertical.PerformLayout();
			this.BarraTitulo.ResumeLayout(false);
			this.panelReg.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnRestore;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnJumlahMurid;
		private System.Windows.Forms.Button btnCetakRaportPAS;
		private System.Windows.Forms.Button btnNilaiKeterampilan;
		private System.Windows.Forms.Button btnAbsensi;
		private System.Windows.Forms.Button btnCetakRaportPTS;
		private System.Windows.Forms.Button btnRekapNilai;
		private System.Windows.Forms.Button btnNilaiSikap;
		private System.Windows.Forms.Button btnNilaiPengetahuan;
	}
}