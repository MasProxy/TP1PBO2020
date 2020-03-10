using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_PBO
{
    class Barang
    {
        public int Id { get; set; }//menampung id
        public int Harga { get; set; }//menampung harga
        public string NamaBarang { get; set; }//menampung nama barang
        public string Jenis { get; set; }//menampung jenis
        public string Deskripsi { get; set; }//menampung deskripsi

        public Barang(int Id,int Harga, string NamaBarang, string Jenis, string Deskripsi)
        {
            this.Id = Id;
            this.NamaBarang = NamaBarang;
            this.Harga = Harga;
            this.Jenis = Jenis;
            this.Deskripsi = Deskripsi;
        }

        public Barang()
        {
        }
    }
}
