namespace Proje04_TipDonusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {  /* 
            byte a = 5;
            short b = 10;
            sbyte c = 30;
            int d = a + b + c;// Implicit Convert - Örtülü dönüştürme
            Console.WriteLine($"Sonuç(d)={d}");

            string metin = "NBUY";
            char karakter = 'k';
            object e = metin + karakter + d;//object her bir şeyin ortak atası (Implicit Convert)
            Console.WriteLine($"Object={e}");
            */
            /*
            byte a = 155;
            byte b = 101;
            //byte c =Convert.ToByte(a+b);// Explicit Convert - Bilinçli Dönüşüm
            //Console.WriteLine($"Sonuç(c):{c}");

            byte d = (byte)(a + b);// Unboxing
            Console.WriteLine($"Sonuç(d): {d}");*/
            /*
            int a = 511;
            byte b = (byte)a;
            Console.WriteLine(b);
            */

            byte a = 155;
            byte b = 101;
            int c = a + b; //Otomatik dönüşüm yapıyor
            Console.WriteLine($"Sonuç(c):{c}");

            Convert.ToDouble(c);
            Convert.ToInt64(c);

        }
    }
}