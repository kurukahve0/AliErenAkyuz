using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanılcı = new Dictionary<int, string>();

            kullanılcı.Add(10, "Ahmet Yılmaz");
            kullanılcı.Add(11, "Ali Eren");
            kullanılcı.Add(1, "Müslüm Gürses");
            kullanılcı.Add(2, "Sezen Aksu");


            Console.WriteLine(kullanılcı[1]);

            foreach (var item in kullanılcı)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(kullanılcı.Count);

            Console.WriteLine(kullanılcı.ContainsKey(1));
            Console.WriteLine(kullanılcı.ContainsValue("a"));

            kullanılcı.Remove(10);
            foreach (var item in kullanılcı)
            {
                Console.WriteLine(item);
            }

            foreach (var item in kullanılcı)
            {
                Console.WriteLine(item.Key);
            }
            foreach (var item in kullanılcı)
            {
                Console.WriteLine(item.Value);
            }
            Console.ReadKey();
        }
    }
}
