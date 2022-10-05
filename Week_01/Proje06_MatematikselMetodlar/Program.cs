namespace Proje06_MatematikselMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi1 = 43;
            int sayi2 = 55;
            int minumum= Math.Min(sayi1, sayi2);//iki sayıyı karılaştırır sadece
            int max= Math.Max(sayi1, sayi2);
            Console.WriteLine($"Minumum sayı:{minumum}\nMaksimum sayı:{max}");
            Console.WriteLine(minumum);
            */
            /*
            int taban = 4;
            int us = 3;
            double sonuc=Math.Pow(taban, us);
            Console.WriteLine(sonuc);
            */
            /*
            Console.Write("Taban: ");
            int taban = Convert.ToInt32( Console.ReadLine());
            Console.Write("Üs: ");
            int us=int.Parse( Console.ReadLine());//stringi ınt çevirmek için
            double  sonuc=Math.Pow(taban, us);
            Console.WriteLine($"Girmiş olduğunuz sayıların sonucu:{sonuc}");
            */

            double sayi = 5.493486;

            Console.WriteLine(Math.Ceiling(sayi));//yukarı tam sayıya yuvarlama 
            Console.WriteLine(Math.Floor(sayi));//aşağı tam sayıya yuvarlama 
            Console.WriteLine(Math.Round(sayi,2));// virgülden sonra ne kadar olsun


        }
    }
}