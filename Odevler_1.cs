using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {   //******* Soru 1 **********
            /*  Console.WriteLine("Kaç adet sayı gireceksiniz");
              int n = int.Parse(Console.ReadLine());
              Console.WriteLine("Sayıları giriniz");
              int[] sayilar = new int[n];
              for (int i = 0; i < n; i++)
                  sayilar[i] = int.Parse(Console.ReadLine());


              foreach (var item in sayilar)
              {
                  if (item % 2 == 0)
                      Console.WriteLine(item);
              }
              */

            //******** Soru 2 ***********
            /* Console.WriteLine("iki adet sayı girin");
             int n = int.Parse(Console.ReadLine());
             int m = int.Parse(Console.ReadLine());

             Console.WriteLine("Sayıları giriniz");
             int[] sayilar = new int[n];
             for (int i = 0; i < n; i++)
                 sayilar[i] = int.Parse(Console.ReadLine());


             foreach (var item in sayilar)
             {
                 if (item % m == 0 || item==m)
                     Console.WriteLine(item);
             }*/


            //******** Soru 3 ********

            /* Console.WriteLine("iki adet sayı girin");
            int n = int.Parse(Console.ReadLine());
            

            Console.WriteLine("kelimeleri giriniz");
            string[] kelimeler = new string[n];
            for (int j = 0; j < n; j++)
            {
                kelimeler[j] = Console.ReadLine();
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.Write(kelimeler[i] + " ");
            }*/
            // ******** Soru 4 ********
            Console.WriteLine("Cümle giriniz");
            string cumle = Console.ReadLine();

            string[] dizi = cumle.Split(' ');
            int harfSayisi = 0;
            Console.WriteLine("Kelime Sayısı :{0}", dizi.Length);

            cumle = String.Join("", dizi);
            
            Console.WriteLine("Harf Sayısı :{0}", cumle.Length);

            Console.ReadKey();

        }

        


    }

}
