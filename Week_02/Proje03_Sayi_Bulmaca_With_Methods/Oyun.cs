using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje03_Sayi_Bulmaca_With_Methods
{
    public static class Oyun
    {
        public static int SayiUret()
        {
            Random random = new Random();
            int sayi = random.Next(1, 101);
            return sayi;
        }

        public static int Tahmin(int tahminSiraNo)
        {
            Console.WriteLine($"{tahminSiraNo}. tahmininizi giriniz: ");
            return int.Parse(Console.ReadLine());
        }
        public static string TespitEt(int tahmin,int sayi)
        {
            if (tahmin > sayi)
            {
                return "Daha küçük bir sayı gir.";
            }
            return "Daha büyük bir sayı gir.";
        }

        public static void Oyna()
        {
            int sayi = SayiUret();
            int tahmin = 0;
            int puan = 50;
            string mesaj = "";
            bool sonuc=false;
            Console.WriteLine($"Hile | Üretilen sayı: {sayi}");
            for (int i = 1; i <= 5; i++)
            {
                tahmin = Tahmin(i);
                if (tahmin==sayi)
                {
                    sonuc = true;
                    break;
                }
                mesaj = TespitEt(tahmin, sayi);
                puan -= 10;
            }

            mesaj=sonuc==true?$"Kazandınız,puanınız: {puan}":"Kaybettiniz
        }
    }
}
