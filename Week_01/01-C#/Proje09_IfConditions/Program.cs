namespace Proje09_IfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * if(bool)
             * {
             *      logical true ise yapılacak işler
             * }
             */
            /*
            int sayi=Convert.ToInt32(Console.ReadLine());
            if (sayi>=0)
            {
                Console.WriteLine("Merhaba dünya!");
            }
            */
            /*
            //Kullanıcından yaşını girmesini isteyelim 18 yaşından küçüklere giriş yasak mesajını yazdıralım
            Console.Write("Yaşınızı giriniz: ");
            byte yas=Convert.ToByte(Console.ReadLine());
            if (yas < 18)
            {
                Console.WriteLine("GİRİŞ YASAK!");
            }
            else if (yas>18)
            {
                Console.WriteLine("GİRİŞ SERBEST");
            }
            else
            {
                Console.WriteLine("Velinle birlikte gel!");
            }
            */
            /*
            //Girilnen iki sayıdan büyük olanı yazdır.

            Console.Write("1.Sayıyı girin: ");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı girin: ");
            int sayi2=Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2)
            {
                Console.WriteLine($"Büyük sayı: {sayi1}");
            }
            else if(sayi1 < sayi2)
            {
                Console.WriteLine($"Büyük sayı: {sayi2}");
            }
            else
            {
                Console.WriteLine($"Sayı 1({sayi1}) ve sayı 2({sayi2}) birbirlerine eşittir.");
            }
            */

            /*
            // Girilen 3 sayıdan büyük olanı yazdıralım

            Console.Write("1.Sayıyı giriniz: ");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz: ");
            int sayi2=Convert.ToInt32(Console.ReadLine());  
            Console.Write("3.Sayıyı giriniz: ");
            int sayi3=Convert.ToInt32(Console.ReadLine());

            if(sayi1 >= sayi2 && sayi1 >= sayi3)
            {
                Console.WriteLine(sayi1);
            }
            else if(sayi2 >= sayi1 && sayi2 >= sayi3)
            {
                Console.WriteLine(sayi2);
            }
            else if(sayi3 >= sayi1 && sayi3 >= sayi2)
            {
                Console.WriteLine(sayi3);
            }


            //bu doğru olmayan algoritma
            /*if (sayi1 > sayi2)
            {
                if(sayi1 > sayi3)
                {
                    Console.WriteLine(sayi1);
                }
            }
            else if(sayi2>sayi1)
            */


            Console.Write("1.Sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            string sonuc = sayi1 > sayi2 ? "1.Sayı 2.Sayıdan büyüktür." :
                                    sayi2 > sayi1 ? "2.Sayı 1.Sayıdan büyüktür." : 
                                        "İki sayı birbirine eşittir";
            Console.WriteLine(sonuc);



            //int buyukSayi = sayi1 > sayi2 ? sayi1 : sayi2;
            //Console.WriteLine(buyukSayi);

            /*int buyukSayi=0;
            if (sayi1 > sayi2)
            {
                buyukSayi = sayi1;
            }
            else if(sayi2 > sayi1)
            {
                buyukSayi = sayi2;
            }
            Console.WriteLine(buyukSayi);
            */




        }
    }
}