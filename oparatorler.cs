using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            bool isSuccess = true;
            bool isComplated = false;

            if (isComplated && isSuccess)
                Console.WriteLine("Perfect");
            if (isComplated || isSuccess)
                Console.WriteLine("great");
            if (!isComplated && isSuccess)
                Console.WriteLine("Fine");


            int a = 3, b = 4;


            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);


            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;

            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++; //
            Console.WriteLine(sonuc1);


            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);

            Console.ReadKey();



        }
    }
}
