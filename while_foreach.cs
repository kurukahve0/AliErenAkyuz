using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayi>=sayac)
            {
                
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam / sayi);
            

            char karekter = 'a';

            while (karekter<'z')
            {
                Console.Write(karekter);
                karekter++;
            }
            Console.WriteLine();

            string[] arabalar = {"bmw","audi","ford","opel" };

            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
