using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken1 = "Dersimiz Csharp, Hoşgeldiniz!";
            string degisken2 = "Csharp";

            
            Console.WriteLine(degisken1.Length);

            Console.WriteLine(degisken1.ToUpper());
            Console.WriteLine(degisken2.ToLower());

            Console.WriteLine(string.Concat(degisken2," Merhaba!"));

            Console.WriteLine(degisken1.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken1,degisken2,true));
            Console.WriteLine(String.Compare(degisken1, degisken2, false));

            Console.WriteLine(degisken1.Contains(degisken2));
            Console.WriteLine(degisken1.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken1.StartsWith("Dersimiz"));

            Console.WriteLine(degisken1.IndexOf("Cs"));

            Console.WriteLine(degisken1 + degisken2.PadRight(30, '*'));
            Console.WriteLine(degisken1.PadLeft(31, '*') + degisken2);

            Console.WriteLine(degisken2.Remove(0, 1));
            Console.WriteLine(degisken1.Remove(10));

            Console.WriteLine(degisken1.Replace("Csharp","c#"));

            Console.WriteLine(degisken1.Split(' ')[2]);

            Console.WriteLine(degisken1.Substring(0, 10));
            Console.ReadKey();
        }
    }
}
