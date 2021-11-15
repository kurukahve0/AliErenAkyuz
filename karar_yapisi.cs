using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karar_yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time < 6 && time < 11)
                Console.WriteLine("Günaydın");
            else if (time <= 18)
                Console.WriteLine("İyi günler");
            else
                Console.WriteLine("İyi akşamlar");

            string Sonuc = time >= 18 ? "İyi geceler" : "iyi Günler";

            Sonuc = time >= 6 && time <= 11 ? "Günaydın" : time <= 18 ? "İyi günler":"İyi Geceler";
            Console.WriteLine(Sonuc);

            Console.ReadKey();

        }
    }
}
