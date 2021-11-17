using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            bool a = int.TryParse(sayi, out int deger);
            if (a)
            {
                Console.WriteLine("Başarılı\n{0}", deger);
            }
            else
                Console.WriteLine("Başarısız");

           

            metotlar metot = new metotlar();

            metot.Topla(5, 3, out int sonuc);


            Console.WriteLine(sonuc);
            Console.ReadKey();
            Console.WriteLine("***********-");
            int ifade = 999;
            metot.EkranaYaz(ifade.ToString());
            metot.EkranaYaz(ifade);
            metot.EkranaYaz("Ali", "Eren",out string adSoyad);
            Console.WriteLine(adSoyad);
            Console.ReadKey();
        }

    }
    class metotlar
    {
        public void Topla(int a, int b, out int Toplam)
        {
             Toplam = a + b;
        }
        public void EkranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYaz(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYaz(string veri1,string veri2,out string adSoyad)
        {
            adSoyad = veri1 + " " + veri2;
            Console.WriteLine(adSoyad);
        }

    }
}
