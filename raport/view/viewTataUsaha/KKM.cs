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
    public partial class KKM : Form
    {
        public KKM()
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

        int numOfMulok = 0;
        private void next_Click(object sender, EventArgs e)
        {
           TextBox a = new TextBox();
            int count = panel2.Controls.OfType<TextBox>().ToList().Count;
            a.Text = "";
            a.Location = new Point(0, 40*count);
            a.Size = new Size(80,20);
            panel2.Controls.Add(a);

            NumericUpDown value = new NumericUpDown();
            value.Text = (0).ToString();
            value.Location = new Point(280, 40 * count);
            value.Size = new Size(64, 27);
            panel2.Controls.Add(value);




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
