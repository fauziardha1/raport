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
    public partial class IdenKepsek : Form
    {
        public IdenKepsek()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSavekepsek_Click(object sender, EventArgs e)
        {
            KepsekModel kepsek = new KepsekModel(namaKepsek.Text,nipKepsek.Text,comboGender.Text);
            try
            {
                Connection db = new Connection();
                var result = db.client.Set<KepsekModel>("KepalaSekolah/", kepsek);
                if (result.StatusCode.ToString().Equals("OK"))
                {
                    MessageBox.Show("Data inserted succesfully");
                }
                else
                {
                    MessageBox.Show("Internet Problem!"); 
                }
            }
            catch
            {
                MessageBox.Show("Intenet problem!");
            }
        }
    }
}
