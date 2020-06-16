using DocumentFormat.OpenXml.Math;
using raport.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace raport
{
    public partial class IdenSiswa : Form
    {
        private bool statusSend =false;
        private Siswa siswa = new Siswa();
        public IdenSiswa()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboKelas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            siswa.namaLengkap = this.namaLengkapSiswa.Text;
            siswa.namaPanggilan = this.namaPanggilanSiswa.Text;
            siswa.nomorInduk = this.noIndukSiswa.DecimalPlaces;
            siswa.nisn = this.nisn.DecimalPlaces;
            siswa.agama = this.comboAgama.SelectedItem.ToString();
            siswa.ttl = this.ttl.Text;
            siswa.anakKe = this.anakKe.DecimalPlaces;
            siswa.jumlahSaudara = this.jumlahSaudara.DecimalPlaces;
            siswa.bahasaSehari = this.bahasa.Text;
            siswa.alamat = this.alamat.Text;
            siswa.nomorHP = this.noHP.DecimalPlaces.ToString();

            try
            {
                Connection db = new Connection();
                var result = db.client.Set<Siswa>("Siswa/" + siswa.namaPanggilan, siswa);
                if (result.StatusCode.ToString().Equals("OK"))
                {
                    MessageBox.Show("Data inserted succesfully");
                    this.statusSend = true;
                }
                else
                {
                    MessageBox.Show("Internet Problem!");
                }
            }
            catch
            {
                MessageBox.Show("Internet Problem!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
          /*  this.btnSave_Click(sender,e);*/

           /* if (this.statusSend)
            {
                TataUsaha tu = new TataUsaha();
                IdenOrtu ortu = new IdenOrtu();
                tu.AbrirFormEnPanel(ortu);
                tu.Show();
                this.ParentForm.Close();
            }*/


        }
    }
}
