using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_class_dan_object
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengeset nilai prperti objek saya dan kamu
            saya.NIM = "12345";
            saya.Nama = "Hanif";
            saya.IPK = 3.95f;

            kamu.NIM = "123456";
            kamu.Nama = "Hanas";
            kamu.IPK = 2.70f;

            //memanggil method regristasi dan isi KRS
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
