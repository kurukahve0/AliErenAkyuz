using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];


            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(sayilar);
            
            
            int kucukOrt = 0, buyukOrt = 0;

            kucukOrt = (sayilar[0]+sayilar[1]+sayilar[2])/3;
            buyukOrt = (sayilar[sayilar.Length - 1] + sayilar[sayilar.Length - 2] + sayilar[sayilar.Length - 3]) / 3;
            Console.WriteLine("Küçük sayilar ortalama :"+kucukOrt);
            Console.WriteLine("Küçük sayilar ortalama :" + buyukOrt);
            Console.WriteLine("Ortalama Toplam :" + (kucukOrt + buyukOrt));
            Console.ReadKey();
        }
    }
}
