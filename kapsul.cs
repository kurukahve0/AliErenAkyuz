using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsul
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogr = new ogrenci();
            ogr.Isim = "Hayri";
            ogr.Soyisim = "Yılmaz";
            ogr.OgrNo = 10;
            ogr.Sinif = 2;
            ogr.yazdir();

            ogrenci ogr2 = new ogrenci("deniz","kurt",25,1);
            ogr2.sinifDus();
            ogr2.sinifDus();
            ogr2.yazdir();
            Console.ReadKey();

        }
    }

    class ogrenci
    {

        private string isim;
        private string soyisim;
        private int ogrNo;
        private int sinif;

        public string Isim      { get => isim; set => isim = value; }
        public string Soyisim   { get => soyisim; set => soyisim = value; }
        public int OgrNo        { get => ogrNo; set => ogrNo = value; }
        public int Sinif        { get => sinif;
            set
            {
                if (value>1)
                {
                    sinif = value;
                    Console.WriteLine("asdd");
                }
                else { sinif = 1; Console.WriteLine("yanlış"); }
            }
        }
        public ogrenci(string isim,string soyisim,int ogrenciNo,int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrNo = ogrenciNo;
            Sinif = sinif;

        }
        public void sinifDus()
        {
            sinif --;
        }

        public void yazdir()
        {
            Console.WriteLine("Öğrenci adı      : " +isim);
            Console.WriteLine("Öğrenci soyadı   : " + soyisim);
            Console.WriteLine("Öğrenci no       : " + ogrNo);
            Console.WriteLine("Öğrenci sınıfı   : " + sinif);
        }
        public ogrenci()
        {

        }
    }
}
