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
    public partial class idensek : Form
    {
        public idensek()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IdentityOfSchool identitasSekolah = new IdentityOfSchool(
                npsn.Text,
                nama.Text,
                alamat.Text,
                desa.Text,
                kecamatan.Text,
                kota.Text,
                propinsi.Text
                );
            try
            {
                Connection db = new Connection();
                var result = db.client
                    .Set<IdentityOfSchool>("IdentityOfSchool/" +
                    nama.Text+"/",
                    identitasSekolah);
                if(result.StatusCode.ToString().Equals("OK")){
                    MessageBox.Show("Data inserted successfully!");
                    npsn.Clear();nama.Clear();alamat.Clear();desa.Clear();
                    kecamatan.Clear();kota.Clear();propinsi.Clear();
                }
                else
                {
                    MessageBox.Show("failed to insert data!");
                }

            }
            catch
            {
                MessageBox.Show("Failed to insert this data!, \n Please check your internet connection!");
            }
        }
    }
}
