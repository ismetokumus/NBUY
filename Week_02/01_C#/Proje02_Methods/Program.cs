using System.Security.Cryptography;

namespace Proje02_Methods
{
    public class Program
    {
        /*
        static void Topla(int sayi1,int sayi2)//metodlara ilk harf büyük tercih edilir
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine();
            Console.WriteLine($"Toplam: {toplam}");
           
        }
        static void Cikart(int sy1, int sy2)
        {
            int cikar = sy1 - sy2;
            Console.WriteLine();
            Console.WriteLine($"Çıkartma: {cikar}");
        }
        */
        
        //public static int Topla(int sayi1,int sayi2)
        //{
        //    return sayi1 + sayi2;   
        //}
        /*
        static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;//return metoddan gelen veriyi işler geri gönderir. ancak meton türüne göre bu değişyiyor.Void de geri gönderme olmaz
        }
        */
        /*
        static int SiraNoBu()
        {

        }

        static bool VarMi(string metin,char karakter)
        {

        }*/
        static void Main(string[] args)//METHOD
        {
            /*
            Console.Write("Birinci Sayı: ");
            int s1=int.Parse(Console.ReadLine());
            Console.Write("İkinci Sayı: ");
            int s2 = int.Parse(Console.ReadLine());

            

            int toplam= Topla(s1,s2);
            int cikar=Cikar(s1,s2);

            Console.WriteLine($"Toplam: {toplam}, Fark: {cikar}");
            Console.WriteLine($"{toplam-cikar}");
            */

            //Kendisine verilen metnin içerisin de aradığımız karakterin kaçıncı sıra da olduğunu bulan metodu hazırlayınınz
            /*
            Console.Write("Lütfen bir metin giriniz: ");
            string metin = Console.ReadLine();
            Console.Write("Sırasını bulmamızı istedğiniz karakteri giriniz: ");
            string karakter =  Console.ReadLine();

            */
            //Kendisine verilen metnin içinde ,aradığımız karakterlerin olup olmadığını bize söylen bir metodu hazırlayın.
            #region MethodOverloads
            MethodOverload methodOverload = new MethodOverload();

            //Console.WriteLine(methodOverload.Topla(55,66);
            Console.WriteLine(methodOverload.Islem(false,50,10));
            int[] sayilar = { 56, 44, 77, 66, 89, 100, 200 };
            Console.WriteLine(methodOverload.Topla(sayilar));
            #endregion

        }
    }
}