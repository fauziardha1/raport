using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace raport
{
    public partial class GuruKelas : Form
    {
        int grade = 0;
        /* initiate config for firebase connection*/
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XcMixYUmudgztyGv4WtsjraPLds7bvlQNN3LBIxG",
            BasePath = "https://raport-84888.firebaseio.com/"
        };
        /*create client object to interact with firebase*/
        IFirebaseClient client;


        public GuruKelas(int grade)
        {
            this.grade = grade;
            InitializeComponent();
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("There is no internet connection!");
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 50;
            }
            else
                MenuVertical.Width = 250;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnMax.Visible = false;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelReg.Controls.Count > 0)
                this.panelReg.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelReg.Controls.Add(fh);
            this.panelReg.Tag = fh;
            fh.Show();
        }

        private void btnIdenSek_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new idensek());
        }

        private void btnIdenKepSek_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IdenKepsek());
        }

        private void btnIdenGuru_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new IdenGuru());
        }

        private void btnJumlahMurid_Click(object sender, EventArgs e)
        {
            Kelas kelas = new Kelas();
            try
            {
                var result = client.Get("Kelas/" + grade);
                kelas = result.ResultAs<Kelas>();
                
            }
            catch
            {
                MessageBox.Show("There is a problem with internet connection");
            }
            AbrirFormEnPanel(new Murid(kelas.jumlah));
        }

        private void btnNilaiSikap_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new NilaiSikap());
        }

        private void btnNilaiPengetahuan_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new NilaiPengetahuan());
        }

        private void btnNilaiKeterampilan_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new NilaiKeterampilan());
        }

        private void btnRekapNilai_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RekapNilai());
        }

        private void btnAbsensi_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Absensi());
        }
    }
}
