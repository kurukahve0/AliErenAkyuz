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


            Calisan calisan1 = new Calisan("Ali Eren", "Akyüz", 6870, "Game Development");
            
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Kübra";
            calisan2.Soyad = "Sarı";
            calisan2.No = 6871;
            calisan2.Departman = "Satın Alma";
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan();
            calisan3.Ad = "Kamil";
            calisan3.Soyad = "Dayı";
            calisan3.CalisanBilgileri();

            Console.ReadKey();
        }
    }
    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Departman;

        public Calisan()
        {
        }

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;

        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı : " + Ad);
            Console.WriteLine("Çalışanın Soadı : " + Soyad);
            Console.WriteLine("Çalışanın Departmanı : " + Departman);
            Console.WriteLine("Çalışanın No : " + No + "\n");
        }
    }
}





