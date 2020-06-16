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

namespace raport
{
    public partial class GuruAgama_OlahRaga : Form
    {
        public GuruAgama_OlahRaga()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelKelas1.Visible = 
                panelKelas2.Visible = 
                panelKelas3.Visible = 
                panelKelas4.Visible = 
                panelKelas5.Visible = 
                panelKelas6.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelKelas1.Visible == true)
                panelKelas1.Visible = false;
            if (panelKelas2.Visible == true)
                panelKelas2.Visible = false;
            if (panelKelas3.Visible == true)
                panelKelas3.Visible = false;
            if (panelKelas4.Visible == true)
                panelKelas4.Visible = false;
            if (panelKelas5.Visible == true)
                panelKelas5.Visible = false;
            if (panelKelas6.Visible == true)
                panelKelas6.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKelas1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKelas1);
        }

        private void btnKelas2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKelas2);
        }

        private void btnKelas3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKelas3);
        }

        private void btnKelas4_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKelas4);
        }

        private void btnKelas5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKelas5);
        }

        private void btnKelas6_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKelas6);
        }
    }
}
