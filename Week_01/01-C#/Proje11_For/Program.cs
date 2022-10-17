using System;

namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i+1}.Hello, World!");
            }
            */
            /*
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                //toplam=toplam+i;
                toplam += i;
            }
            Console.WriteLine($"Toplam:{toplam}");
            */
            /*
            //1-10 arasındaki çift sayıların toplamını buldurun
            int toplam = 0;
            for (int i = 1; i <= 10; i=1+2)//i=i+2 de yazılanilir.bu yöntem daha az tekrar yapar.
            {
                    toplam = toplam + i;   
            }
            Console.WriteLine(toplam);
            */
            /*
            int toplam = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                }

            }
            Console.WriteLine(toplam);
            */
            //1-10 sayıların çift ve tek sayı top
            /*
            int toplamC = 0;
            int toplamT = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    toplamC = toplamC + i;
                }
                else
                {
                    toplamT = toplamT + i;
                }
            }
            Console.WriteLine($"Çift sayıların toplamı: {toplamC}");
            Console.WriteLine($"Tek sayıların toplamı: {toplamT}");
            */

            //SORU Klavyeden 2 sayı girilsin
            //bu sayıların arasındaki sayıların toplamını ekrana yazdırın
            /*
            Console.Write("1. Sayıyı giriniz: ");
            int sayi1=Convert.ToInt32(Console.ReadLine()); 
            Console.Write("2. Sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = sayi1; i <=sayi2; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"Toplam: {toplam}");
            */
            /*
            Console.Write("1. Sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            if (sayi1 < sayi2)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    toplam += i;
                }
            }
            else
            {
                for (int i = sayi2; i <= sayi1; i++)
                {
                    toplam += i;
                }

            }
            Console.WriteLine($"Toplam: {toplam}");
            */
            /*
            Console.Write("1. Sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int min=Math.Min(sayi1,sayi1);
            int max=Math.Max(sayi1,sayi2);
            for (int i = min; i <= max; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"Toplam: {toplam}");
            */

            //SORU=> Program kullanıcıdan bir sayı girmesini istesin. Ancak kullanıcı sayı girmeye devam etikçe girilen sayıların toplanmasını sağlayalım. Sayı adedi belirsizdir. Uygulamanın bitip, ekrana toplamı yazdırabilmesi için kullanıcı sayı yerine exit yazması lazım.
            /*
            int toplam = 0;
            string girilenDeger = "";
            string sonucMetin = "";
            string sonEk = " + ";
            for (int i = 1; i < 100000; i++)
            {
                Console.Write($" {i}. sayıyı giriniz(Çıkış için exit)[Geçerli toplam: {toplam}]: ");
                girilenDeger=Console.ReadLine();
                if (girilenDeger.ToLower()=="exit")//if küçük büyük harf duyarlıdır.
                {
                    break;//içinde bulunan döngünün tamamlanmasını beklemeden,istenilen bir anda durdurulması için kullanılır
                }
                sonucMetin = sonucMetin + girilenDeger + sonEk;
                toplam +=Convert.ToInt32(girilenDeger);
                
            }
            int alinacakKisminUzunlugu = sonucMetin.Length - sonEk.Length;
            sonucMetin=sonucMetin.Substring(0, alinacakKisminUzunlugu); 
            Console.WriteLine($"{sonucMetin}={toplam}");
            */
            /*
            //SORU 5*5 lik bir kare biçimini yıldız işaretleri oluşturan uygulama.

            
            int satir = 5;
            int sutun = 5;
            for (int i = 0; i < satir; i++)
            {
                //a
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
            }
            */
            /*
            //SORU 5*5 lik bir kare içi boş biçimini yıldız işaretleri oluşturan uygulama.
            

            int satir = 5;
            int sutun = 5;
            for (int i = 1; i <= satir; i++)
            {
                //a
                for (int j = 1; j <= sutun; j++)
                {

                    if (i==1 || i==satir)//eğer 1. veya son satırdaysam
                    {
                        Console.Write("*");
                    }
                    else if (j==1 || j==sutun)//eğer 1. veya son stündaysan
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }
            */
            //ÖDEV Üsttetik içi boş kareyi oluşturan uygulamayı ADIM ADIM çalıştırarak anlamaya çalışın
            //ÖDEV-1 : 1-100 ARASINDAKİ SAYILARIN ORTALAMASINI BULDURAN PROGRAM
            //ÖDEV-2 : 1-100 ARASINDAKİ ÇİFT,TEK VE 5 İN KATI OLAN SAYILARIN ADETLERİ VE TOPLAMLARINI EKRANA YAZDIRAN PROGRAM
            //ÖDEV-3 : AŞAĞIDAKİ YÜKSEKLİĞİ 5, TABANI 9 BİRİM OLAN YILDIZLARDAN OLUŞAN DİK ÜÇGEGİ ÇİZDİREN PROGRAM
            /*
             * *
             * ***
             * *****
             * *******
             * *********
             */
        }
    }
}