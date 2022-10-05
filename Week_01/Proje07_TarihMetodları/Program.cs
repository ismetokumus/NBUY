namespace Proje07_TarihMetodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            DateTime dogumTarihi = new DateTime(1995, 8, 10);
            DateTime bugun = DateTime.Now;
            TimeSpan span=bugun.Subtract(dogumTarihi);
            
            Console.WriteLine($"Toplam {Math.Ceiling( span.TotalDays)} gündür yaşıyorsunuz!");
            */
            /*
            DateTime bugun = DateTime.Now;
            Console.WriteLine(bugun.ToLongDateString());// 5 Ekim 2022 çarşamba
            Console.WriteLine(bugun.ToLongTimeString());// 13:35:30
            Console.WriteLine(bugun.ToShortDateString());//5.10.2022
            Console.WriteLine(bugun.ToShortTimeString());//13:35
            */

            //Bir sonraki yılın ilk gününün tarihini bulalım
            /*
            DateTime bugun=DateTime.Now;
            int yil=bugun.Year+1;
            DateTime sonuc = new DateTime(yil, 1, 1);



            Console.WriteLine(sonuc.ToLongDateString());
            */
            /*
            //Bir sonraki ayın ilk günün tarihini bulduralım

            DateTime bugun=DateTime.Now;
            int yil=bugun.Year;
            int ay=bugun.Month+1;
            DateTime sonuc = new DateTime(yil, ay, 1);
            Console.WriteLine(sonuc);
            */

            DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun+1);

            /*
             * 
             * ö    d   e   v   
             * ertesigünün tarihini bulup ekrana yazdıran programı yazınız.
             */

        }
    }
}