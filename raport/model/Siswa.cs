using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raport.model
{
	class Siswa
	{
		public int nomorInduk { get; set; }
		public string namaLengkap { get; set; }
		public int nisn { get; set; }
		public string namaPanggilan { get; set; }
		public string jenisKelamin { get; set; }
		public string agama { get; set; }
		public string kewarganegaraan { get; set; }
		public string ttl { get; set; }
		public int anakKe { get; set; }
		public int jumlahSaudara { get; set; }
		public string bahasaSehari { get; set; }
		public string alamat { get; set; }
		public string nomorHP { get; set; }
		public string statusTinggal { get; set; }
		public int jarakKeSekolah { get; set; }
		public string pendidikanSebelumnya { get; set; }

		public DataOrangTua dataAyah { get; set; }
		public DataOrangTua dataIbu { get; set; }
		public DataOrangTua wali { get; set; }
	}
}
