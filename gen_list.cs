using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gen_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(-10);
            sayilar.Add(27);
            sayilar.Add(33);
            sayilar.Add(3);

            //sayilar.Clear();
            List<string> renkListe = new List<string>();
            renkListe.Add("sarı");
            renkListe.Add("kırmızı");
            renkListe.Add("pembe");
            renkListe.Add("mor");
            renkListe.Add("mavi");

            Console.WriteLine("adet "+sayilar.Count);
            Console.WriteLine(renkListe.Count);

            sayilar.Remove(-10);
            renkListe.Remove("mor");

            sayilar.ForEach(sayi => Console.WriteLine(sayi));
            renkListe.ForEach(renk => Console.WriteLine(renk));

            if (sayilar.Contains(10))
            {
                Console.WriteLine("10 bulunudu");
            }
            Console.WriteLine(renkListe.BinarySearch("sarı"));
            Console.ReadKey();

            List<Kullanıcılar> kullanıcı = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ali Eren ";
            kullanıcı1.Soyİsim = "Akyüz";
            kullanıcı1.Yas = 26;
            kullanıcı.Add(kullanıcı1);
            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı1.Isim = "Yusuf ";
            kullanıcı1.Soyİsim = "İnan";
            kullanıcı1.Yas = 29;

            
            kullanıcı.Add(kullanıcı2);

            foreach (var item in kullanıcı)
            {
                Console.WriteLine("Kullanıcı Adı : " + item.Isim);
                Console.WriteLine("Kullanıcı Soyadı : " + item.Soyİsim);
                Console.WriteLine("Kullanıcı Yaşı : " + item.Yas);
            }

            Console.ReadKey();
        }
    }
    public class Kullanıcılar
    {
        string isim;

        string soyİsim;

        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyİsim { get => soyİsim; set => soyİsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }


}
