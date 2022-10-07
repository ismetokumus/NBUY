namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
        /*
        //while belirli kural devam ettikçe sonsuz döngüde kullanılır.
        int sayac=1;
        while(sayac<=6)//kışul sağlanıyorsa sürekli döngü içerisinde.
        {
            System.Console.WriteLine("Merhaba !");
            sayac ++;
        }
        */
        /*
        int toplam=0;
        string girilenDeger="";
        int sayac=1;
        while (girilenDeger!="exit")
        {
            System.Console.Write($"{sayac}. sayıyı giriniz(Çıkış için exit): ");
            girilenDeger=Console.ReadLine();
            //if(girilenDeger!="exit") toplam+=Convert.ToInt32(girilenDeger);
            try//hata varsa kullan!!!
            {
                toplam+=Convert.ToInt32(girilenDeger);
            }
            catch (System.Exception)
            {
                Console.WriteLine(toplam);
                break;
            }
            sayac++;
        }
        */
        //Klavyeden exit yazılan kadar isim girilmesini isteyen uygulama.
        //çözüm 1
        /*
        string isim="";
        while (isim!="exit")
        {
            System.Console.Write("İsim giriniz: ");
            isim=Console.ReadLine();
        }
        System.Console.WriteLine("Program sona erdi...");
        */
        //çözüm 2
        /*string isim;
        do
        {
            System.Console.Write("İsim girinzi: "); 
            isim=Console.ReadLine();
        } while (isim!="exit");
        Console.WriteLine("Program sona erdi...");
        */

        //Klavyeden exit yazılana kadar 
        /*
        string girilenDeger;
        int sayac=1;
        int toplam=0;
        do
        {
            System.Console.Write($"{sayac}.sayıyı giriniz: ");
            girilenDeger = Console.ReadLine();
            if (girilenDeger!="exit") toplam+=Convert.ToInt32(girilenDeger);
            sayac++;
        } while (girilenDeger!="exit");
        */
        /*
        //rastgele değer üretme

        Random rastgele=new Random();
        int rastgeleSayi=rastgele.Next();
        System.Console.WriteLine(rastgeleSayi);
        int rastGele2=rastgele.Next(100);//100 dahil değildir. 0 daildir
        System.Console.WriteLine(rastGele2);
        int rastGele3=rastgele.Next(100,200);//100 dahil ve 200 arasın dahil değildir.
        System.Console.WriteLine(rastGele3);
        */

        //OYOUN: Uygulamamnın rastgele uyduracağı bir sayının kullanıcının tahmin etmesini isteyeceğiz.
        //Rastgele üretilecek sayı 1-11 arasında olsun.
        //Kullanıcı rastgele sayıdan küçük yada büyük sayı girdiğinde kullanıcıya düzgün
        //bir şekilde mesaj verilsin.
        //kullanıcı doğru sayıyı tahmin ettiyse ya da 5 hakkını kullandıysa uygulama sona ersin


        Random rnd = new Random();
        int uretilenSayi = rnd.Next(1, 101);
        System.Console.WriteLine($"HİLE: {uretilenSayi}");
        System.Console.WriteLine("*********************");
        int tahminEdilenSayi;
        int hak = 1;//kullanıcının o sırada kaçıncı hakkını kullandığı bilgisi
        int haksiniri = 5;//kullanıcının kaç hakkı kaldığı
        // do
        // {

        //     Console.Write($"{hak}. Tahmininizi giriniz(1-100): ");
        //     tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());

        //     if (hak == haksiniri && uretilenSayi != tahminEdilenSayi)
        //     {
        //         System.Console.WriteLine("KAYBETTİNİZ");
        //         break;
        //     }

        //     if (tahminEdilenSayi > uretilenSayi)
        //     {
        //         System.Console.WriteLine("Büyük bir değer girdiniz , daha küçük bir değer giriniz!");
        //     }
        //     else if (tahminEdilenSayi < uretilenSayi)
        //     {
        //         System.Console.WriteLine("Küçük bir değer girdiniz , daha büyük bir değer giriniz!");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Tebrikler,bildiniz");
        //     }
        //     hak++;



        // } while (tahminEdilenSayi < uretilenSayi && hak <= haksiniri);
        string mesaj = "";
        do
        {
            Console.Write($"{hak}. Tahmininizi giriniz(1-100): ");
            tahminEdilenSayi = Convert.ToInt32(Console.ReadLine());
            if (tahminEdilenSayi > uretilenSayi)
            {
                mesaj = "Büyük girdin!";

            }
            else if (tahminEdilenSayi < uretilenSayi)
            {
                mesaj = "Küçük girdin!";

            }
            if (tahminEdilenSayi != uretilenSayi)
            {
                hak++;
                if (hak <= haksiniri) System.Console.WriteLine(mesaj);
            }


        } while (tahminEdilenSayi != uretilenSayi && hak <= haksiniri);

            mesaj=tahminEdilenSayi==uretilenSayi?"kazandınız": "kaybettiniz";
            System.Console.WriteLine(mesaj);
            /*
        if (tahminEdilenSayi == uretilenSayi)
        {
            System.Console.WriteLine("KAZANDINIZ");
        }
        else
        {
            System.Console.WriteLine("KAYBETTİNİZ");
        }

        //eğer program bu satıra gelmişse ya doğru tahminde bulunulmuştur ya da hak sona ermiştir.
        //KESİNLİKLE BU PROGRAM ÇOK ÇEŞİTLİ/FARKLI ALGORİTMALARLA ÇÖZÜLEBİLİR.
        */




    }
}
