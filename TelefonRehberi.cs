using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Telefonİslemleri telefonUlas = new Telefonİslemleri();
            telefonUlas.BaslangicEkleme();
            telefonUlas.Baslangic();           

        }

        
    }

    class Telefonİslemleri
    {
        Dictionary<string,int> TelefonRehberi=new Dictionary<string, int>();

        public void Baslangic()
        {
            Console.Clear();
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :) \n");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme ");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    YeniTelefonGirme();
                    break;
                case 2:
                    TelefonSilme();
                    break;
                case 3:
                    TelefonGuncelleme();
                    break;
                case 4:
                    Listele();
                    break;
                default:
                    TelefonArama();
                    break;
            }

        }

        public void TelefonEkleme(int _numara, string _isim)
        {
            TelefonRehberi.Add(_isim,_numara);

        }

        public void TelefonArama()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string secim = Console.ReadLine();
            Console.WriteLine("Arama için giriniz");
            string cevap = Console.ReadLine();
            switch (Convert.ToInt32(secim))
            {
                case 1:
                    if (TelefonRehberi.ContainsKey(cevap))
                    {
                        Console.WriteLine(TelefonRehberi[cevap]);
                        Console.ReadKey();
                        Baslangic();
                    }
                    else Baslangic();
                    break;               
                default:
                    if (TelefonRehberi.ContainsValue(Convert.ToInt32(cevap)))
                    {
                        Console.WriteLine(TelefonRehberi[cevap]);
                        Console.ReadKey();
                        Baslangic();
                    }
                    else Baslangic();

                    break;
            }



        }

        public void Listele()
        {
            foreach (var item in TelefonRehberi)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Baslangic();
        }

        public void TelefonGuncelleme()
        {
            Console.Clear();
            Console.WriteLine("Lütfen numarasını Güncellemek istediğiniz kişinin adını ve soyadını giriniz:");
            string _isimSoyisim = Console.ReadLine();
            if (TelefonRehberi.ContainsKey(_isimSoyisim))
            {
                Console.WriteLine($"{TelefonRehberi[_isimSoyisim]} isimli kişi rehberden güncellemek üzere, onaylıyor musunuz ?(y/n)");
                string cevap = Console.ReadLine();
                if (cevap == "y")
                {
                    TelefonRehberi.Remove(_isimSoyisim);

                    YeniTelefonGirme();
                    
                }
                else
                {
                    Baslangic();
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Baslangic();
                        break;
                    default:
                        TelefonGuncelleme();
                        break;
                }

            }


        }
        public void TelefonSilme()
        {
            Console.Clear();
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");
            string _isimSoyisim = Console.ReadLine();
            if (TelefonRehberi.ContainsKey(_isimSoyisim))
            {
                Console.WriteLine($"{TelefonRehberi[_isimSoyisim]} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string cevap = Console.ReadLine();
                if (cevap == "y")
                {
                    TelefonRehberi.Remove(_isimSoyisim);
                    Baslangic();
                }
                else
                {
                    Baslangic();
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Baslangic();
                        break;                   
                    default:
                        TelefonSilme();
                        break;
                }

            }

        }

        public void BaslangicEkleme()
        {
            TelefonEkleme(1431, "Ali Eren");
            TelefonEkleme(25234, "Yavuz Taştan");
            TelefonEkleme(1233, "İlkkan Er");
            TelefonEkleme(4423, "Yılmaz Boğa");
            TelefonEkleme(5442, "Hayri Yıldırım");

        }

        public void YeniTelefonGirme()
        {
            Console.Clear();
            string _isim, _soyIsim;
            int _no;
            Console.WriteLine("Lütfen isim giriniz             :");
            _isim = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            _soyIsim = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            _no =Convert.ToInt32( Console.ReadLine());

            TelefonEkleme(_no, _isim + " " + _soyIsim);
            Baslangic();
        }

        
        



    }
}
