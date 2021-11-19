using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ArryList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add("Ayşe");
            list.Add(true);
            list.Add('A');

            Console.WriteLine(list[1]);

            foreach (var item in list)
                Console.WriteLine(item);

            string[] renkler = { "sarı", "mavi", "mor", "kahverengi" };
            List<int> sayilar = new List<int>{3,2,7};

            Console.ReadKey();
            list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach (var item in list)
                Console.WriteLine(item);

          

          //  Console.WriteLine(list.BinarySearch(3));

            list.Reverse();
            foreach (var item in list)
                Console.WriteLine(item);
            Console.ReadKey();

            list.Clear();
            foreach (var item in list)
                Console.WriteLine(item);

        }
    }
}
