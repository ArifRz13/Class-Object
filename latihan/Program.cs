using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat objek dari class mahasiswa
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            // Mengeset nilai propertis objek saya dan kamu 
            saya.Nim = "12345";
            saya.Nama = "Jono";
            saya.IPK = 3.95f;

            kamu.Nim = "123456";
            kamu.Nama = "Paijo";
            kamu.IPK = 3.70f;

            // memanggil method registrasi dan isi krs
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();

        }
    }
}
