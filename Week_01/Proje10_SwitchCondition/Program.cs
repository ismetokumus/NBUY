namespace Proje10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen bir sayının 5 olması halinde 2 katını, 10 olması halinde 3 katını ya da 15 olması halinde ise 4 katını 
            //ekrana yazan programı hazırlayalım. Eğer üçü de değilse Tanınmayan Değer yazsın
            /*
            Console.Write("Lütefen bir sayı giriniz(5-10-15): ");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            //int sonuc = sayi1 == 5 ? sayi1 * 2 : sayi1 == 10 ? sayi1 * 10 : sayi1 == 15 ? sayi1 * 4;
            int sonuc = 0;
            switch (sayi1)
            {
                case 5:
                    sonuc = sayi1 * 2;
                    break;//bakmayı durdurmak için.
                case 10:
                    sonuc= sayi1 * 3;
                    break;
                case 15:
                    sonuc= sayi1 * 4;
                    break;
                
                default:
                    sonuc = 0;
                    break;
            }
            if (sonuc == 0)
            {
                Console.WriteLine("Tanımlanmamış değer!");
            }
            else
            {
                Console.WriteLine(sonuc);
            }




            /*
            if (sayi1 == 5)
            {
                sonuc = sayi1 * 2;
            }
            else if (sayi1 == 10)
            {
                sonuc = sayi1 * 3;
            }
            else if (sayi1 == 15)
            {
                sonuc = sayi1 * 4;
            }
            Console.Write(sonuc);   
            */


            //x-> <10 -> 2 ile çarpsın
            //x-> 11-20 -> 3 ile çarpsın
            //x-> 21-50 -> 4 ile çarpsın
            //x-> 51-100 -> 5 ile çarpsın
            //x-> >100 -> 10 ile çarpsın

            //Çözüm IF ile
            /*
            int x = 35;
            //int sonuc = 0;
            int katsayı = 0;
            if (x <= 10)
            {
                katsayı=2;
            }
            else if (x <= 20)
            {
                katsayı=3;                
            }
            else if (x <= 50)
            {
                katsayı = 4;
            }
            else if (x <= 100)
            {
                katsayı = 5;
            }
            else
            {
                katsayı = 10;
            }
            int sonuc = x * katsayı;
            Console.WriteLine($"X={x}, Sonuç: {x}*{katsayı} = {sonuc}");
            */
            /*
            int x = 55;
            int katsayı = 0;
            switch (x)
            {       
                case (>=0 and <=10):
                    katsayı = 2;
                    break;
                case (>= 11 and <= 20):
                    katsayı = 3;
                    break;
                case (>= 21 and <= 50):
                    katsayı = 4;
                    break;
                case (>= 51 and <= 100):
                    katsayı = 5;
                    break;
                default:
                    katsayı = 6;
                    break;
            }
            int sonuc = x * katsayı;
            Console.WriteLine($"X={x}, Sonuç: {x}*{katsayı} = {sonuc}");
            */

            //İçinde bulunduğumuz günün hafta içimi sonumu
            DateTime tarih = new DateTime(2022, 10, 8);
            DayOfWeek gun=tarih.DayOfWeek;

            //if (gun==DayOfWeek.Sunday||gun==DayOfWeek.Saturday)
            //{
            //    Console.WriteLine("Hafta sonundasın, haydi gez eğlen");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta içindesin, çalış çalış çalış");
            //}
            /*
            switch (gun)
            {
                
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hafta içindesin ,üzgünüm çalışmalısın!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Hafta sonu gelmiş,gez ve mutlaka dinlen!");
                    break;
                default:
                    break;
            }*/
            switch (gun)
            {

                case DayOfWeek.Monday or
                            DayOfWeek.Tuesday or
                            DayOfWeek.Wednesday or
                            DayOfWeek.Thursday or 
                            DayOfWeek.Friday:
                    Console.WriteLine("Hafta içindesin ,üzgünüm çalışmalısın!");
                    break;
                case DayOfWeek.Saturday or DayOfWeek.Sunday:
               
                    Console.WriteLine("Hafta sonu gelmiş,gez ve mutlaka dinlen!");
                    break;
                default:
                    break;
            }

        }
    }
}