using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            BoardIslmleri boardIslmleri = new BoardIslmleri();
            boardIslmleri.Baslangic();

        }

    }
    class BoardIslmleri
    {
        Dictionary<int, string[]> todo = new Dictionary<int, string[]>();
        Dictionary<int, string[]> inProgress = new Dictionary<int, string[]>();
        Dictionary<int, string[]> done = new Dictionary<int, string[]>();

        public void Baslangic()
        {
            Console.Clear();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("******************************************* ");
            Console.WriteLine("(1) Board Listelemek ");
            Console.WriteLine("(2) Board'a Kart Eklemek ");
            Console.WriteLine("(3) Board'dan Kart Silmek ");
            Console.WriteLine("(4) Kart Taşımak ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Listeleme();
                    break;
                case 2:
                    Console.WriteLine("Hangi tahtaya eklemek istersiniz Todo(1) InProgress(2) Done(3)");
                    BoardEkleme(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 3:
                    BoardSilme();
                    break;
                case 4:
                    KartDegistir();
                    break;                   
                
            }
        }
        void Listeleme()
        {
            Console.Clear();
            Console.WriteLine(" TODO Line");
            Console.WriteLine("******************************************* ");
            
            foreach (var item in todo)
            {
                Console.WriteLine("Başlik       :" + item.Value[0]);
                Console.WriteLine("İçerik       :" + item.Value[1]);
                Console.WriteLine("Atanan Kişi  :" + item.Value[3]);
                Console.WriteLine("Buyukluk  :" + item.Value[2]);
            }
            Console.WriteLine(" - ");
            Console.WriteLine(" InProgress Line");
            Console.WriteLine("******************************************* ");
            foreach (var item in inProgress)
            {
                Console.WriteLine("Başlik       :" + item.Value[0]);
                Console.WriteLine("İçerik       :" + item.Value[1]);
                Console.WriteLine("Atanan Kişi  :" + item.Value[3]);
                Console.WriteLine("Atanan Kişi  :" + item.Value[2]);
            }
            Console.WriteLine(" - ");
            Console.WriteLine(" Done Line");
            Console.WriteLine("******************************************* ");
            foreach (var item in done)
            {
                Console.WriteLine("Başlik       :" + item.Value[0]);
                Console.WriteLine("İçerik       :" + item.Value[1]);
                Console.WriteLine("Atanan Kişi  :" + item.Value[3]);
                Console.WriteLine("Atanan Kişi  :" + item.Value[2]);
            }
            Console.WriteLine(" - ");
            Console.ReadKey();
            Baslangic();
        }

        void KartDegistir()
        {
            Console.Clear();
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine(" Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();
            bool bulundu = false;
            foreach (var item in todo)
            {
                if (item.Value[0] == baslik)
                {
                    KartSecimi(item.Value,"ToDo", item.Key);
                    todo.Remove(item.Key);
                    bulundu = true;
                    break;
                }
            }
            foreach (var item in inProgress)
            {
                if (item.Value[0] == baslik)
                {
                    KartSecimi(item.Value,"InProgress", item.Key);
                    inProgress.Remove(item.Key);
                    bulundu = true;
                    break;
                }
            }
            foreach (var item in done)
            {
                if (item.Value[0] == baslik)
                {
                    KartSecimi(item.Value,"Done",item.Key);
                    done.Remove(item.Key);
                    bulundu = true;
                    break;
                    
                }
            }
            if (!bulundu)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * İşlemi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Baslangic();
                }
                else KartDegistir();

            }
            else Baslangic();
        }

        void KartSecimi(string[] kart,string line,int key)
        {
            Console.Clear();
            Console.WriteLine("Başlik       :" + kart[0]);
            Console.WriteLine("İçerik       :" + kart[1]);
            Console.WriteLine("Atanan Kişi  :" + kart[3]);
            Console.WriteLine("Büyüklük     :" + kart[2]);
            Console.WriteLine("Line         :" + line);
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: \n  (1) TODO \n  (2) IN PROGRESS \n  (3) DONE ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    todo.Add(key, new string[4] { kart[0], kart[1], kart[3], kart[2] });
                    break;
                case 2:
                    inProgress.Add(key, new string[4] { kart[0], kart[1], kart[3], kart[2] });
                    break;
                case 3:
                    done.Add(key, new string[4] { kart[0], kart[1], kart[3], kart[2] });
                    break;
            }
            

        }

        void BoardSilme()
        {
            Console.Clear();
            Console.WriteLine("Lütfen kart başlığını yazınız:  ");
            string baslik = Console.ReadLine();
            bool bulundu = false;
            foreach (var item in todo)
            {
                if (item.Value[0]==baslik)
                {
                    todo.Remove(item.Key);
                    bulundu = true;
                }
            }
            foreach (var item in inProgress)
            {
                if (item.Value[0] == baslik)
                {
                    inProgress.Remove(item.Key);
                    bulundu = true;
                }
            }
            foreach (var item in done)
            {
                if (item.Value[0] == baslik)
                {
                    done.Remove(item.Key);
                    bulundu = true;
                }
            }
            if (!bulundu)
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)");
                Console.WriteLine(" * Yeniden denemek için : (2)");
                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Baslangic();
                }
                else BoardSilme();

            }
            else Baslangic();
        }
        void BoardEkleme(int secim)
        {
            Console.Clear();
            Console.WriteLine(" Başlık Giriniz                                  :");
            string baslik = Console.ReadLine();
            Console.WriteLine(" İçerik Giriniz                                  :");
            string icerik = Console.ReadLine();
            Console.WriteLine(" Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            string buyukluk = Console.ReadLine();
            Console.WriteLine(" Kişi Seçiniz                                    :");
            string kisi = Console.ReadLine();
            Console.WriteLine(" Takım üyesi ID giriniz                          :");
            int id =Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    todo.Add(id, new string[4] { baslik, icerik, buyukluk, kisi });
                    break;
                case 2:
                    inProgress.Add(id, new string[4] { baslik, icerik, buyukluk, kisi });
                    break;
                case 3:
                    done.Add(id, new string[4] { baslik, icerik, buyukluk, kisi });               
                    break;
            }            
            Baslangic();
        }
        enum Buyukluk
        {
            xs=1,
            s=2,
            m=3,
            l=4,
            xl=5
                

        }


    }
  

}
