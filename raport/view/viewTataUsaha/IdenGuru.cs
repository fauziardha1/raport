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
    public partial class IdenGuru : Form
    {
        public IdenGuru()
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
            GuruModel guru = new GuruModel(
                namaGuru.Text,
                nipGuru.Text,
                comboGender.Text,
                comboKelas.Text,
                1,
                "password"
                );
            try
            {
                Connection db = new Connection();
                var result = db.client.Set<GuruModel>("Guru/"+namaGuru.Text, guru);
                MessageBox.Show(result.StatusCode.ToString());
            }
            catch
            {
                MessageBox.Show("no intenet connection");
            }
        }
    }
}
