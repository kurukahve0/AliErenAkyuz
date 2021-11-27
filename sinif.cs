using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif
{
    class Program
    {
        static void Main(string[] args)
        {


            Calisan calisan1 = new Calisan();
            calisan1.ad = "Ali Eren";
            calisan1.soyad = "Akyüz";
            calisan1.no = 6870;
            calisan1.departman = "Game Development";
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.ad = "Kübra";
            calisan2.soyad = "Sarı";
            calisan2.no = 6871;
            calisan2.departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Console.ReadKey();

        }
    }
    class Calisan
    {
        public string ad;

        public string soyad;

        public int no;

        public string departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : " + ad);
            Console.WriteLine("Çalışanın Soadı : " + soyad);
            Console.WriteLine("Çalışanın Departmanı : " + departman);
            Console.WriteLine("Çalışanın No : " + no+"\n");

        }


    }
}
