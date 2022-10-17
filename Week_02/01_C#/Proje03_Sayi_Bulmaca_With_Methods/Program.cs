namespace Proje03_Sayi_Bulmaca_With_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sayı bulmaca oyununu,yeni öğrendiğimiz methods konusu bağlamında yeniden hazırlayınız.
            /*
             * 1) 5 Tercih hakkı olsun.
             * 2) Puan sistemi olsun.(1. Tercihinde bildiyse 50, bilmedikçe 10'ar 10'ar düşsün.)
             * 3) Oyunu kaybettiğinde ya da kazandığında YENİDEN OYNAMAK İSTİYOR ise OYNAYABİLSİN.
             */

            string tercih;
            do
            {
                Console.Clear();
                Oyun.Oyna();
                do
                {
                    Console.Write("Yeniden oynamak istermisiniz?[E/H]");
                    tercih = Console.ReadLine().ToUpper();

                } while (tercih!="H" && tercih!="E");

            } while (tercih!="H");
            Console.ReadLine();
            
        }
    }
}