﻿namespace Proje15_Class_Property_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrNo = 11;
            ogrenci1.Ad = "Ahmet";
            ogrenci1.Sinif = "9A";

            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci2.OgrNo= 12;
            ogrenci2.Ad = "Selim";
            ogrenci2.Sinif = "10B";

            Ogrenci ogrenci3 = new Ogrenci() { OgrNo = 15, Ad = "Umay", Sinif = "10C" };

            Ogrenci[] ogrenciler = {ogrenci1, ogrenci2, ogrenci3};
            /*
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine($"Ad: {ogrenciler[i].Ad}, Sınıf: {ogrenciler[i].Sinif}");
            }
            */
            
            foreach (var siradakiOgrenci in ogrenciler)
            {
                Console.WriteLine(siradakiOgrenci.Ad  + "," + siradakiOgrenci.Sinif);
            }
            
            /*
            int[] sayilar = { 32, 54, 33 };
            foreach (var siradakiSayi in sayilar)
            {
                Console.WriteLine(siradakiSayi*siradakiSayi);
            }
            */

        }
        class Ogrenci
        {
            private int ogrNo;//verilerigizlmek için bu şekilde kullanıyoruz sınıflarda verilere get kısmında istadiğimiz kadarını veriyoruz.Banka sistemlerinde özellikle kullanılır.

            public int OgrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            }

            /*public string Ad { get; set; }//burda istenilen bilgilerin hepsi direkt verilir.*/
            private int ad;

            public int Ad
            {
                get { return ad; }
                set { ad = value; }
            }

            public string Sinif { get; set; }

        }
    }
}