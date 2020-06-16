using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Charts;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace raport
{
    public partial class Form1 : Form
    {

        
            
        public Form1()
        {
            InitializeComponent();

            User newUser = new User();
            newUser.username = "Fauzi";
            newUser.password = "arda";
            newUser.kelas = 1;
            newUser.role = 1;

            /*var request = WebRequest.CreateHttp()*/
            Connection db = new Connection();
            db.client.Set<User>("Test/fauzi", newUser);
        }
                
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            userLogin.Clear();
            picUser.BackgroundImage = Properties.Resources.user2;
            userLogin.ForeColor = Color.FromArgb(78, 184, 206);
            panelUser.BackColor = Color.FromArgb(78, 184, 206);

            picPass.BackgroundImage = Properties.Resources.pass1;
            passLogin.ForeColor = Color.WhiteSmoke;
            panelPass.BackColor = Color.WhiteSmoke;
        }

        private void passLogin_Click(object sender, EventArgs e)
        {
            passLogin.Clear();
            passLogin.PasswordChar = '*';
            picPass.BackgroundImage = Properties.Resources.pass2;
            passLogin.ForeColor = Color.FromArgb(78, 184, 206);
            panelPass.BackColor = Color.FromArgb(78, 184, 206);

            picUser.BackgroundImage = Properties.Resources.user1;
            userLogin.ForeColor = Color.WhiteSmoke;
            panelUser.BackColor = Color.WhiteSmoke;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            /*register reg1 = new register();
            reg1.Show();
            this.Hide();*/

            /* TextBox a = new TextBox();
             a.Text = (5 + 1).ToString();
             a.Location = new Point(50, 50);
             this.Controls.Add(a);*/

            /*KKM kkm = new KKM();
            kkm.Show();
            this.Hide();*/

            NilaiSikap nilaiSikap = new NilaiSikap();
            nilaiSikap.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private async void  btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection db = new Connection();
                var result = db.client.Get("Login/users/");
                List<User> users = result.ResultAs<List<User>>();
                int role = 0;
                int grade = 0;

                foreach (User user in users)
                {
                    if (user != null)
                    {
                        if(userLogin.Text.Equals(user.username) && passLogin.Text.Equals(user.password))
                        {
                            role = user.role;
                            grade = user.kelas;
                        }
                    }
                }

                switch (role)
                {
                    case 1: 
                        GuruKelas kelas = new GuruKelas(grade);
                        kelas.Show();
                        this.Hide();
                        break;
                    case 2:
                        GuruAgama_OlahRaga agama = new GuruAgama_OlahRaga();
                        agama.Show();
                        this.Hide();
                        break;
                    case 3:
                        KepalaSekolah kepsek = new KepalaSekolah();
                        kepsek.Show();
                        this.Hide();
                        break;
                    case 4:
                        TataUsaha tu = new TataUsaha();
                        tu.Show();
                        this.Hide();
                        break;
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with internet connection!");
            }
        }

        private void userLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

