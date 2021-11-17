using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod_tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine(a + b);

            Console.WriteLine(Topla(a, b));

            Metodlar metod = new Metodlar();
            metod.EkranaYaz(Topla(a, b).ToString());

            int sonuc = metod.sonuc(ref a, ref b);
            Console.WriteLine(sonuc);
            Console.WriteLine(a + b);
            Console.ReadKey();

        }
        static int Topla(int deger1,int deger2)
        {
            return deger1 + deger2;
        }
    }
    class Metodlar
    {
        public void EkranaYaz(string value)
        {
            Console.WriteLine(value);
        }

        public int sonuc(ref int deger1,ref int deger2)
        {
            deger1++;
            deger2++;
            return deger1 + deger2;


        }
    }
}
