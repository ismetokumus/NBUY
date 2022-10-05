namespace Proje05_MetinselMetodlar;
class Program
{
    static void Main(string[] args)
    {
        // Bu projede metinsel işlemlere dair bazı metodlar öğreniceğiz
        /*
        string metin = "Wissen Akademie";
        int uzunluk = metin.Length;
        Console.WriteLine($"{metin} metni {uzunluk} karakterdir.");
        */
        /*
        string metin = "WİSSEN";
        string kucukMetin=metin.ToLower();
        Console.WriteLine(kucukMetin);
        string buyukMetin = kucukMetin.ToUpper();
        Console.WriteLine(buyukMetin);
        */
        /*
        string m1 = "Wissen";
        string m2 = "Wissen";
        int sonuc = String.Compare(m1, m2);
        Console.WriteLine(m1);
        Console.WriteLine(m2);
        Console.WriteLine(sonuc);
        */
        /*
        Console.Write("1.Metni giriniz:");
        string m1 = Console.ReadLine();
        Console.Write("2.Metni giriniz:");
        string m2 = Console.ReadLine();
        int sonuc = String.Compare(m1, m2);// Compare küçük büyük harf duyarlı
        if (sonuc==0)
        {
            Console.WriteLine("Girilen iki metin birbirine EŞİTTİR!");
        }
        else
        {
            Console.WriteLine("Girilen iki metin birbirinden FARKLIDIR!");
        }
        */
        /*
        string m1 = "İşkur";
        string m2 = "Eğitimleri";
        string m3 ="Wissen";
        string sonuc=String.Concat(m1, m2, m3);
        Console.WriteLine(sonuc);
        */
        /*
        string ad = "İsmet";
        int yas = 27;
        string okul = "BAU";
        //Sonuc 1
        string deger="Benim adım "+ ad +". "+ yas+"yaşındayım. Okuduğum okulun adı" + okul+".";
        Console.WriteLine(deger);
        Console.WriteLine($"Benim adım {ad}. {yas} yaşındayım. Okuduğum okulun adı {okul}." );
        string sonuc=String.Concat(ad, okul);
        */
        /*
        string metin = "Merhaba. Bu hafta eğitime başladık.";
        bool sonuc = metin.Contains(" ");//kelime içinde ki birebir kelimeyi arar. Sonuc True - False
        Console.WriteLine(sonuc);
        */

        // string adres = "Selami şehit Ali mh. Can sk. No:6 Kadıköy/İstanbul";
        /*
        bool sonuc = adres.EndsWith("İstanbul");//Sonunda ki kelimeyi kontrol eder.
        bool sonuc2 = adres.StartsWith("İstanbul");
        Console.WriteLine(sonuc+ ", "+sonuc2);
        */

        // adres içindeki c harfi kaçıncı sıradadır.
        /*
        string aranacakIfade = "Ş";
        
        int siraNo = adres.ToLower().IndexOf(aranacakIfade.ToLower());
        Console.WriteLine($"C harfi {adres} içinde, {siraNo} sıradadır");
        */

        /*
        string aranacakIfade = "Şehit Ali";

        int siraNo = adres.ToUpper().IndexOf(aranacakIfade.ToUpper());
        Console.WriteLine($"{aranacakIfade} ifadesi, {adres} içinde,{siraNo} sıradadır.");
        */
        /*
        string metin = "Wissen Akademia";
        Console.WriteLine($"Metnin ilk hali :{metin}");
        Console.WriteLine($"Akademia ifadesi silidikten sonraki hali :{metin.Remove(7)}");
        Console.WriteLine($"Aka ifadesi silindikten sonraki hali:{metin.Remove(7,3)}");
        */

        string urunAd = "IPhone 13 Pro";
        //iphone-13-pro
        //string sonuc = (urunAd.Replace(" ", "-")).ToLower();
        string sonuc = urunAd.ToLower().Replace(" ", "-");
        Console.WriteLine(sonuc);
        string sonuc2 = urunAd.Replace("IPhone", "Samsung");
        Console.WriteLine(sonuc2);

    }
}
