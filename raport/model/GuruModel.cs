using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raport.model
{
	class GuruModel
	{
		public string nama { get; set; }
		public string nip { get; set; }
		public string jenisKelamin { get; set; }
		public string kelas { get; set; }
		public bool statusOfApproval { get; set; }
		public int role { get; set; }
		public string password { get; set; }

		public GuruModel(string nama, string nip, string jenisKelamin, string kelas, int role, string password)
		{
			this.nama = nama;
			this.nip = nip;
			this.jenisKelamin = jenisKelamin;
			this.kelas = kelas;
			this.statusOfApproval = false;
			this.role = role;
			this.password = password;
		}
	}
}
