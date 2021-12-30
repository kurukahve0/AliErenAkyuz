using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)gunler.Pazar);

            int sicaklik = 27;

            if (sicaklik < (int)havaDurumu.soguk)
                Console.Write("hava soğuk çıkma");
            else if (sicaklik > (int)havaDurumu.normal && sicaklik < (int)havaDurumu.sıcak)
                Console.WriteLine("dışarı çıkmak için iyi bir hava");
            else if (sicaklik > (int)havaDurumu.sıcak && sicaklik < (int)havaDurumu.cokSıcak)
                Console.WriteLine("dışarı çıkmak için sıcak bir hava");
            else if (sicaklik > (int)havaDurumu.cokSıcak)
                Console.WriteLine("yapma yanarsın");
            Console.ReadKey();
        }
    }

    enum gunler
    {
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
    }
    enum havaDurumu
    {
        soguk=5,
        normal=20,
        sıcak=25,
        cokSıcak=30
    }
}
