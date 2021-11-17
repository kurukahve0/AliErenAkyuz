using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metot_exrek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int result = 1;
              for (int i = 1; i < 5; i++)

                  result *= 3;

                  Console.WriteLine(result);
              islem carpım = new islem();
              Console.WriteLine(carpım.expo(4, 3)); */


            string ad = "Ali Eren Akyüz";
            
            if (ad.checkSpaces())
            {
                Console.WriteLine("Başarılı");
            }
            Console.WriteLine( ad.removeSpaces());
            Console.WriteLine(ad.Upper());

            int[] dizi = { 1, 2, 7, 6, 3 };
            dizi.Siralama();
            dizi.Yazdir();

            int sayi = 5;
            
            Console.WriteLine(sayi.ciftKontrol());

            Console.WriteLine(ad.ilkHarf());
            Console.ReadKey();
        }
    }

    public class islem
    {
        public int expo(int us,int sayi)
        {
            if (us == 0)
                return 1;
            else
                return expo(us - 1,sayi ) * sayi;
        }
    }

    public static class extec
    {
        public static bool checkSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string removeSpaces(this string isim)
        {
            string[] ad = isim.Split(' ');

            return string.Join("", ad);
        }
        public static string Upper(this string isim)
        {
            return isim.ToUpper();
        }
        public static int[] Siralama(this int[] sayi)
        {
            Array.Sort(sayi);
            return sayi;
        }
        public static void Yazdir(this int[] sayi)
        {
            foreach (var item in sayi)
            {
                Console.WriteLine(item);
            }
        }
        public static bool ciftKontrol(this int sayi)
        {
            return sayi % 2 == 0;
        }
        public static string ilkHarf(this string isim)
        {
            return isim.Substring(0, 1);
        }
    }
}
