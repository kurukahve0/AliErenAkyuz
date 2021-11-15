using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipDonusum
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string e = "zikriye";
            char f = 'k';
            object g = e + f + d;

            Console.WriteLine("g: " + g);



            string s1 = "5", s2 = "10";
            int sayi1 = Convert.ToInt32(s1), sayi2 = Convert.ToInt32(s2);
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
            Parse();
            Console.ReadKey();

        }

        public static void Parse()
        {
            string metin1 = "10", metin2 = "10.25";
            int rakam1=Int32.Parse(metin1);
            double rakam2=double.Parse(metin2);
            Console.WriteLine($"rakam1 : {rakam1}\nrakam2 : {rakam2}");
            

        }

    }
   
}
