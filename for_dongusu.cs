using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı giriniz : ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                Console.WriteLine(i);
            }

            int tektoplam=0, cifttoplam=0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 1)
                    tektoplam += i;
                else
                    cifttoplam += i;
            }
            Console.WriteLine("tek : "+tektoplam);
            Console.WriteLine("çift : " + cifttoplam);

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
