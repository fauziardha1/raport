namespace raport
{
    partial class Form1
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
			this.btnClose = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelUser = new System.Windows.Forms.Panel();
			this.panelPass = new System.Windows.Forms.Panel();
			this.picPass = new System.Windows.Forms.PictureBox();
			this.picUser = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.userLogin = new System.Windows.Forms.TextBox();
			this.passLogin = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnReg = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 50);
			this.panel1.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.AutoSize = true;
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.btnClose.Location = new System.Drawing.Point(529, 9);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(14, 13);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "X";
			this.btnClose.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(90, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "UPTD SD NEGERI 01 SUAYAN";
			// 
			// panelUser
			// 
			this.panelUser.BackColor = System.Drawing.Color.White;
			this.panelUser.Location = new System.Drawing.Point(200, 135);
			this.panelUser.Name = "panelUser";
			this.panelUser.Size = new System.Drawing.Size(320, 1);
			this.panelUser.TabIndex = 4;
			// 
			// panelPass
			// 
			this.panelPass.BackColor = System.Drawing.Color.White;
			this.panelPass.Location = new System.Drawing.Point(200, 195);
			this.panelPass.Name = "panelPass";
			this.panelPass.Size = new System.Drawing.Size(320, 1);
			this.panelPass.TabIndex = 5;
			// 
			// picPass
			// 
			this.picPass.BackgroundImage = global::raport.Properties.Resources.pass1;
			this.picPass.Location = new System.Drawing.Point(200, 160);
			this.picPass.Name = "picPass";
			this.picPass.Size = new System.Drawing.Size(30, 30);
			this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picPass.TabIndex = 3;
			this.picPass.TabStop = false;
			// 
			// picUser
			// 
			this.picUser.BackgroundImage = global::raport.Properties.Resources.user1;
			this.picUser.Location = new System.Drawing.Point(200, 100);
			this.picUser.Name = "picUser";
			this.picUser.Size = new System.Drawing.Size(30, 30);
			this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picUser.TabIndex = 2;
			this.picUser.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::raport.Properties.Resources.Icon;
			this.pictureBox1.Location = new System.Drawing.Point(25, 75);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// userLogin
			// 
			this.userLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.userLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.userLogin.HideSelection = false;
			this.userLogin.Location = new System.Drawing.Point(236, 108);
			this.userLogin.Name = "userLogin";
			this.userLogin.Size = new System.Drawing.Size(284, 22);
			this.userLogin.TabIndex = 6;
			this.userLogin.TabStop = false;
			this.userLogin.Text = "Nama Guru";
			this.userLogin.Click += new System.EventHandler(this.userLogin_Click);
			this.userLogin.TextChanged += new System.EventHandler(this.userLogin_TextChanged);
			// 
			// passLogin
			// 
			this.passLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.passLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passLogin.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.passLogin.HideSelection = false;
			this.passLogin.Location = new System.Drawing.Point(236, 167);
			this.passLogin.Name = "passLogin";
			this.passLogin.Size = new System.Drawing.Size(284, 22);
			this.passLogin.TabIndex = 7;
			this.passLogin.TabStop = false;
			this.passLogin.Text = "Password";
			this.passLogin.Click += new System.EventHandler(this.passLogin_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Green;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.DarkSeaGreen;
			this.btnLogin.Location = new System.Drawing.Point(208, 233);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(130, 30);
			this.btnLogin.TabIndex = 8;
			this.btnLogin.Text = "Masuk";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnReg
			// 
			this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReg.ForeColor = System.Drawing.Color.DarkSeaGreen;
			this.btnReg.Location = new System.Drawing.Point(379, 233);
			this.btnReg.Name = "btnReg";
			this.btnReg.Size = new System.Drawing.Size(130, 30);
			this.btnReg.TabIndex = 9;
			this.btnReg.Text = "Daftar";
			this.btnReg.UseVisualStyleBackColor = true;
			this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.ClientSize = new System.Drawing.Size(550, 300);
			this.Controls.Add(this.btnReg);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.passLogin);
			this.Controls.Add(this.userLogin);
			this.Controls.Add(this.panelPass);
			this.Controls.Add(this.panelUser);
			this.Controls.Add(this.picPass);
			this.Controls.Add(this.picUser);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox passLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReg;
    }
}

