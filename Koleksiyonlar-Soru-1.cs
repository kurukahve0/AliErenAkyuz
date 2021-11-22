using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asal_olmayan = new ArrayList();
            int sayi = 0;
             while (asal.Count+asal_olmayan.Count!=20)
             {

                try
                {
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi<0)
                    {
                        Console.WriteLine("Negatif giriş");
                        continue;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Numeric olmayan giriş");
                    continue;
                }
                
                if (sayi == 2 || sayi == 1)
                {
                    asal.Add(sayi);
                }
                else
                {
                    for (int i = 3; i < sayi; i++)
                    {

                        if (sayi % i == 0)
                        {
                            asal_olmayan.Add(sayi);
                           
                            break;
                        }
                        else if (i == sayi - 1)
                        {
                            asal.Add(sayi);
                           
                        }
                    }
                }
            }
            asal_olmayan.Sort();
            asal_olmayan.Reverse();
            asal.Sort();
            asal.Reverse();
            foreach (var item in asal)
            {
                Console.WriteLine("Asal :"+item);
            }
            foreach (var item in asal_olmayan)
            {
                Console.WriteLine("Asal Olmayan:" + item);
            }

            int asal_toplam = 0, asalOlmayan_toplam = 0;

            foreach (int item in asal)
            {
                asal_toplam += item;
            }
            foreach (int item in asal_olmayan)
            {
                asalOlmayan_toplam += item;
            }

            Console.WriteLine("Asal ortalama :" + asal_toplam / asal.Count);
            Console.WriteLine("Asal olmayan ortalama :" + asalOlmayan_toplam / asal_olmayan.Count);

            Console.ReadKey();
        }
    }
}
