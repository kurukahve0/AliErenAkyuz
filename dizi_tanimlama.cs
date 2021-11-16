using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizi_tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            renkler[3] = "mavi";
            dizi[2] = 3;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[3]);
            Console.WriteLine(dizi[2]);

            Console.WriteLine("Dizinin uzunluğunu giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var item in sayiDizisi)
            {
                toplam += item;
            }
            Console.WriteLine("Sayının ortalaması: {0}", toplam / diziUzunlugu);

            Console.ReadKey();




        }
    }
}
