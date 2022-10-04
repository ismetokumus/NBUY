namespace Proje02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir değişkene isim verirken;
            //1) Alfanümerik karakterler kullanılmaz.(Alt tire (_) hariç).
            //2) Türkçe karakter kullanılmaz.(Zorunlu değil).
            //3) Özel ya da ayrılmış sözcükler kullanılmaz.
            //4) Değişken isimleri büyük küçük har duyarlıdır.
            //5) Değişken tanıımlarken tek kelime ise küçük harf kullan.İki kelime ise ilk kelime küçük
            //harfler diğerleri büyük harflerle.
            //string adsoyad; //değişken isminde özel karkter olamaz
            // coment ctlr+k+c tersi ctrl+k+u

            //string adSoyad;
            //adSoyad = "Alex de Souza";
            //Console.WriteLine(adSoyad);
            //Console.WriteLine("adSoyad");//Tırnak içinde yazarsan ne yazarsan o çıkar.
            /*
            int yas;
            yas = 19;
            Console.WriteLine(yas);

            string adSoyad = "Ahmet Candan";
            Console.WriteLine(adSoyad);

            Console.WriteLine("Adı:" + adSoyad + ", Yaşı:" + yas);*/

            //Tam sayı

            //Console.WriteLine(byte.MinValue + "-" + byte.MaxValue);
            //Console.WriteLine(int.MinValue + "-" + int.MaxValue);
            //Console.WriteLine(long.MinValue + "-" + long.MaxValue);
            byte sayi1 = 255;
            int sayi2 = 45;
            long sayi3 = 12345678915131;
            /*
            string sayi4 = "15";
            Console.WriteLine(sayi4+2);*/

            //ONADALIKLI SAYI
            float a = 10.5f;// hassas ise 
            double b = 20.6;
            decimal c = 100.65m; //parasal ise bu 

            //KARAKTER VE METİN

            string name = "İsmet OKUMUŞ";
            char cinsiyet = 'E';//içinde sadece tek karakter tuta bilen tip

            //MANTIKSAL
            bool evliMi= true
            


        }
    }
}