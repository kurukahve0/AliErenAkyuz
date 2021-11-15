using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                Console.WriteLine("Bir Sayı Giriniz :");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı :" + sayi);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                
            }finally
            {
                Console.WriteLine("İşlem Tamam");

            }

            try
            {
                int a = Convert.ToInt32(-20000000000);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("boş değer girilmez");
                Console.WriteLine(ex.Message.ToString());               
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format farklı");
                Console.WriteLine(ex.Message.ToString());

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Büyük yada küçük sayı girdiniz");
                Console.WriteLine(ex.Message.ToString());
            }
            Console.ReadKey();
        }
    }
}
