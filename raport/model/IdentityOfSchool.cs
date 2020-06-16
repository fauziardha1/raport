using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raport
{
	class IdentityOfSchool
	{
		public string npsn { get; set; }
		public string nama { get; set; }
		public string alamat { get; set; }
		public string desa { get; set; }
		public string kecamatan { get; set; }
		public string kota { get; set; }
		public string provinsi { get; set; }

		public IdentityOfSchool(string npsn, string nama, string alamat, string desa, string kecamatan, string kota, string provinsi)
		{
			this.npsn = npsn;
			this.nama = nama;
			this.alamat = alamat;
			this.desa = desa;
			this.kecamatan = kecamatan;
			this.kota = kota;
			this.provinsi = provinsi;
		}
	}
}
