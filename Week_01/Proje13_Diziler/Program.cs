namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //string adSoyad = "Fatih Candan, Cemal Gündem, Selin Dilci";
            //Console.WriteLine(adSoyad);
            string[] adlar = new string[7];//İçinde 7 adet string bilgi tutabilecek bir dizi
            adlar[0] = "Fatih CAndan";
            adlar[1] = "Cemal Gündem";
            adlar[2] = "Selin Dilci";
            adlar[3] = "Kemal Kurt";
            adlar[4] = "Begüm Yancı";
            adlar[5] = "Selma Halıcı";
            adlar[6] = "Emre Mor";
            //Console.WriteLine(adlar[0]);

            for (int i = 0; i < adlar.Length; i++)
            {
                Console.WriteLine(adlar[i]);
            }
            */
            int[] yaslar = new int[3];

            int[] rakamlar = { 56, 89, 90, 45, 33, 53 };
            /*int toplam = 0;

            for (int i = 0; i < rakamlar.Length; i++)
            {
                toplam+=rakamlar[i];
            }
            Console.WriteLine(toplam);
            */
            //string okul = "Wissen Akademie";
            //Console.WriteLine(okul[0]);
            // Çalışma klavyeden kullanıcının adını soyadını girmesini isteyiniz
            //Girilen ad soyad aşağıya doğru büyük harflerle yadırınız
            /*
            Console.Write("Ad-Soyad giriniz: ");
            string kullanıcı = Console.ReadLine().ToUpper();
            
            for (int i = 0; i < kullanıcı.Length; i++)
            {
                Console.WriteLine(kullanıcı[i]);
            }
            */
            /*
            Console.Write("Bir metin giriniz: ");
            string girilenMetin=Console.ReadLine().ToLower();
            Console.Write("Hangi karakteri bulmamı istersiniz? ");
            string karakter=Console.ReadLine().ToLower(); 
            int siraNo=girilenMetin.IndexOf(karakter)+1;
            Console.Clear();
            Console.WriteLine($"Girilen Metin: {girilenMetin}\nAradığınız Karakter: {karakter}\nAradığınız karakterin Girilen Metindeki Sırası: {siraNo}");
            */
            /*
            Console.WriteLine("Dizinin Orjinal Hali");
            Console.WriteLine("********************");
            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine($"{i+1}.Eleman:\t{rakamlar[i]}");
            }
            Console.WriteLine();
            */
            /*
            int enBuyuk = rakamlar[0];
            int enKucuk=rakamlar[0];
            for (int i = 0; i < rakamlar.Length; i++)
            {

                if (enBuyuk < rakamlar[i])
                {
                    enBuyuk = rakamlar[i];
                }
                if (rakamlar[i]<enKucuk)
                {
                    enKucuk = rakamlar[i];
                }
                
            }
            Console.WriteLine(enBuyuk);
            Console.WriteLine(enKucuk);,

            //İSTEĞE BAĞLI ÇALIŞMA ÖDEVİ : Bu diziyi küçükten büyüğe sıralayınız.
           
            //Kendimiz en büyük sayıyı buluyoruz.

            //Console.WriteLine($"En Küçük:\t{rakamlar.Min()}");
            //Console.WriteLine($"En Büyük:\t{rakamlar.Max()}");
            */
            /*
            Console.WriteLine("Dizinin Ters Çevrilmiş Hali");
            Console.WriteLine("***************************");
            Array.Reverse(rakamlar);//Dizi elemanlarını ters çevirmek için
            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            }
            Console.WriteLine();
            */
            /*
            Console.WriteLine("Dizinin Küçükten-Büyüğe Sıralanmış Hali");
            Console.WriteLine("***************************************");
            Array.Sort(rakamlar);//Dizi elemanlarını küçükten büyüğe sıralamak için
            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            }
            Console.WriteLine();
            

            Console.WriteLine("Dizinin Büyükten-Küçüğe Sıralanmış Hali");
            Console.WriteLine("***************************************");
            Array.Sort(rakamlar);//Dizi elemanlarını küçükten büyüğe sıralamak için
            Array.Reverse(rakamlar);
            for (int i = 0; i < rakamlar.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Eleman:\t{rakamlar[i]}");
            }
            Console.WriteLine();
            */

            //ÖRNEKLER:
            //ÖRNEK:1 Sayılar dizisinin elemanlarının ortalamasını bulup ekrana yazınız.

            //int[] sayilar = { 5, -16, 12, -15, 78, 90, 0 };

            //int toplam = sayilar.Sum();
            //Console.WriteLine($"Toplam: {toplam}");

            //ÖRNEK:2 Sayılar dizisindeki çift sayıları ekrana yazdıralım.
            /*
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i]%2==0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
            */

            //ÖRNEK:3 Sayılar dizisindeki sayıları yanlarında pozitif,negatif ya da işaretsiz olma bilgileriyle yazdıralım
            /*
            string tip = "";
            for (int i = 0; i < sayilar.Length; i++)
            {
                tip = sayilar[i] > 0 ? "Pozitif" :
                    sayilar[i] < 0 ? "Negatif":
                                     "İşaretsiz";
                Console.WriteLine($"{i+1}.Sayı: {sayilar[i]} - Tipi: {tip}");
            }
            */

            //ÖRNEK:4 Kullanıcının gireceği bir metnin içerisindeki sesli harf sayısını ekranan yazdıralım.
            /*
            char[] sesliHarf = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            int sesliHarfAdeti = 0;
            Console.Write("Bir metin giriniz: ");
            string girilenMetin = Console.ReadLine().ToLower();
            for (int i = 0; i < girilenMetin.Length; i++)
            {
                if (sesliHarf.Contains(girilenMetin[i]))// contains iki string içindeki aynı harfleri bulmak için
                {
                    sesliHarfAdeti++;
                }
            }
            Console.WriteLine(sesliHarfAdeti);
            */

            //ÖRNEK:5 Klavyeden girilen bir cümledeki yine klavyeden girilecek bir kelimenin kaç kez geçtiğini bulduralım.
            /*
            string ornekMetin = "İsmet Okumuş İstanbul";
            string[] sözcükDizisi=ornekMetin.Split(" ");//split cümleyi parçalayıp dizi  yapar

            for (int i = 0; i < sözcükDizisi.Length; i++)
            {
                Console.WriteLine(sözcükDizisi[i]);
            }
            */

            int sozcukAdedi = 0;
            Console.Write("Cümleyi giriniz: ");
            string girilenCumle = Console.ReadLine();
            Console.Write("Adedini bulmak istediğiniz sözcüğü giriniz: ");
            string sayilacakSozcuk=Console.ReadLine();
            string[] girilenCümleninDiziHali = girilenCumle.Split(" ");
            for (int i = 0; i < girilenCümleninDiziHali.Length; i++)
            {
                if (sayilacakSozcuk.ToLower() == girilenCümleninDiziHali[i].ToString().ToLower())
                {
                    sozcukAdedi++;

                }
            }
            Console.WriteLine($"'{girilenCumle}' cümlesi içinde '{sayilacakSozcuk}' sözcüğü {sozcukAdedi} kez geçmektedir!" );


            //******************************
            //ARAŞTIRMA ÖDEVİ: ÇOK BOYUTLU DİZİLERİ ARAŞTIRIN.
            //******************************
            

            //********************************
            //PROJE ÖDEVİ
            /*
             * İçinde Türkçe karakterler hariç tüm küçük harfler,0-9 arası rakamlar, nokta(.), virgül(,), artı(+), eksi(-) karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE üreten programı yazınız.*/
            //********************************

            //engin.ergul@wissenakademie.com

            

            
        }
    }
}