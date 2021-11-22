using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] a = s.ToCharArray();
            string sesli_harf = "";
            foreach (var item in a)
            {
                switch (item)
                {
                    case 'a':
                    case 'e':
                    case 'ı':
                    case 'i':
                    case 'u':
                    case 'ü':
                    case 'o':
                    case 'ö':
                        sesli_harf += item;
                        break;
                }
            }
            char[] b = sesli_harf.ToCharArray();
           // Console.WriteLine();
            foreach (var item in b)
            {
                Console.Write(item + ",");
            }
            Console.ReadKey();
        }
    }
}
