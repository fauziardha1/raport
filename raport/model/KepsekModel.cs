using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace raport.model
{
	class KepsekModel
	{
		public string nama { get; set; }
		public string nip { get; set; }
		public string jenisKelamin { get; set; }

		public KepsekModel(string nama, string nip, string jenisKelamin)
		{
			this.nama = nama;
			this.nip = nip;
			this.jenisKelamin = jenisKelamin;
		}
	}
}
