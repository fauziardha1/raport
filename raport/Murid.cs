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
	public partial class Murid : Form
	{
		int jumlah=0;
		public Murid(int jumlah)
		{
			this.jumlah = jumlah;
			InitializeComponent();
		}

		private void Murid_Load(object sender, EventArgs e)
		{
			this.label1.Text += jumlah;
		}
	}
}
