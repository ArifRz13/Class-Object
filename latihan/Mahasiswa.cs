﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_01
{
    public class Mahasiswa
    {
        // Propertis
        public string Nim { get; set; }
        public string Nama { get; set; }
        public float IPK { get; set; }

        // Method
        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("NIM  : {0}", Nim);
            Console.WriteLine("IPK  : {0}", IPK);
            Console.WriteLine("Telah melakukan registrasi");
        }

        public void IsiKrs()
        {
            Console.WriteLine("{0} Sedang melakukan proses KRS\n", Nama);
        }
    }
}
