using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arry_sınıf
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 22, 17, 53, 99, 85, 77 };

            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Array.Sort(sayiDizisi);
            Console.WriteLine("*******Sıralı*******");
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);
            Console.WriteLine("*******clear*******");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);
            Console.WriteLine("*******Ters*******");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);
            Console.WriteLine("*******İndex*******");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 99));

            Console.WriteLine("*******Resize*******");
            Array.Resize<int>(ref sayiDizisi, 7);
            sayiDizisi[6] = 876;
            foreach (var item in sayiDizisi)
                Console.WriteLine(item);

            Console.ReadKey();


        }
    }
}
