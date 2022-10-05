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
        }
    }
}