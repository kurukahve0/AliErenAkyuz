using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 2;
            sbyte sb = 2;

            short s = 2;
            ushort us = 65365;

            Int16 deg = 2;
            int deg1 = 2;
            Int32 deg2 = 2;
            Int64 deg3 = 3;
            uint deg4 = 2;//pozitif

            long l = -12333;
            ulong ul = 1233;

            float f = 0.256f;
            double d = 0.256;
            decimal de = 0.256m;

            char ch = 'a';
            string se = "Merhaba";

            object s1 = "Merhaba";
            object s2 = 4;

            bool kontrol = true;

            string isim=null, soyisim="",yeni_st2="2";
            isim = "Ali";
            soyisim = "Akyüz";
            Console.WriteLine(isim + " " + soyisim);


            string yeni_st = "aa" + s2.ToString();
            int yeni = Convert.ToInt32(yeni_st2) + 5;

            bool bool1 = 10 < 2;


            string zaman = DateTime.Now.ToString("dd.mm.yyyy");

            string zaman1 = DateTime.Now.ToString("HH:mm");

            Console.WriteLine(zaman1);
            Console.ReadKey();
        }
    }
}
