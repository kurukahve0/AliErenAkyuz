using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month-7;

            switch (month)
            { case 10:
                    Console.WriteLine("Ekim ayındasınız");
                    break;
                case 11:
                    Console.WriteLine("Kasım ayındasınız");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındasınız");
                    break;    
            }

            switch (month)
            {
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimi");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz Mevsimi");
                    break;
            }


            Console.ReadKey();
        }
    }
}
