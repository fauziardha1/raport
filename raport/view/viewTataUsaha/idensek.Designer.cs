namespace raport
{
    partial class idensek
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
			this.btnClose = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnIdenSek = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.propinsi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.kota = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.kecamatan = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.desa = new System.Windows.Forms.TextBox();
			this.alamat = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.npsn = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.AutoSize = true;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(952, 5);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(20, 20);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "X";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.ForestGreen;
			this.panel1.Controls.Add(this.btnIdenSek);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(950, 50);
			this.panel1.TabIndex = 6;
			// 
			// btnIdenSek
			// 
			this.btnIdenSek.BackColor = System.Drawing.Color.ForestGreen;
			this.btnIdenSek.FlatAppearance.BorderSize = 0;
			this.btnIdenSek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnIdenSek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIdenSek.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIdenSek.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnIdenSek.Image = global::raport.Properties.Resources.school;
			this.btnIdenSek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIdenSek.Location = new System.Drawing.Point(305, 7);
			this.btnIdenSek.Name = "btnIdenSek";
			this.btnIdenSek.Size = new System.Drawing.Size(332, 40);
			this.btnIdenSek.TabIndex = 4;
			this.btnIdenSek.Text = "IDENTITAS SEKOLAH";
			this.btnIdenSek.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 21);
			this.label2.TabIndex = 8;
			this.label2.Text = "NAMA ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSave);
			this.groupBox1.Controls.Add(this.propinsi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.kota);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.kecamatan);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.desa);
			this.groupBox1.Controls.Add(this.alamat);
			this.groupBox1.Controls.Add(this.nama);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.npsn);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(25, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(901, 350);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Identitas Sekolah";
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
			// propinsi
			// 
			this.propinsi.Location = new System.Drawing.Point(200, 284);
			this.propinsi.Name = "propinsi";
			this.propinsi.Size = new System.Drawing.Size(500, 27);
			this.propinsi.TabIndex = 21;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 290);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 21);
			this.label7.TabIndex = 20;
			this.label7.Text = "PROPINSI";
			// 
			// kota
			// 
			this.kota.Location = new System.Drawing.Point(200, 244);
			this.kota.Name = "kota";
			this.kota.Size = new System.Drawing.Size(500, 27);
			this.kota.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 250);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 21);
			this.label6.TabIndex = 18;
			this.label6.Text = "KOTA/KABUPATEN";
			// 
			// kecamatan
			// 
			this.kecamatan.Location = new System.Drawing.Point(200, 204);
			this.kecamatan.Name = "kecamatan";
			this.kecamatan.Size = new System.Drawing.Size(500, 27);
			this.kecamatan.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 210);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 21);
			this.label5.TabIndex = 16;
			this.label5.Text = "KECAMATAN";
			// 
			// desa
			// 
			this.desa.Location = new System.Drawing.Point(200, 164);
			this.desa.Name = "desa";
			this.desa.Size = new System.Drawing.Size(500, 27);
			this.desa.TabIndex = 15;
			// 
			// alamat
			// 
			this.alamat.Location = new System.Drawing.Point(200, 124);
			this.alamat.Name = "alamat";
			this.alamat.Size = new System.Drawing.Size(500, 27);
			this.alamat.TabIndex = 14;
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(200, 84);
			this.nama.Name = "nama";
			this.nama.ReadOnly = true;
			this.nama.Size = new System.Drawing.Size(500, 27);
			this.nama.TabIndex = 13;
			this.nama.Text = "UPTD SD NEGERI 01 SUAYAN";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 170);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(154, 21);
			this.label4.TabIndex = 12;
			this.label4.Text = "DESA/KELURAHAN";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 21);
			this.label3.TabIndex = 11;
			this.label3.Text = "ALAMAT";
			// 
			// npsn
			// 
			this.npsn.Location = new System.Drawing.Point(200, 44);
			this.npsn.Name = "npsn";
			this.npsn.Size = new System.Drawing.Size(500, 27);
			this.npsn.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 21);
			this.label1.TabIndex = 9;
			this.label1.Text = "NPSN";
			// 
			// idensek
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(976, 561);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "idensek";
			this.Text = "idensek";
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIdenSek;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox propinsi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kecamatan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desa;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox npsn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nama;
    }
}