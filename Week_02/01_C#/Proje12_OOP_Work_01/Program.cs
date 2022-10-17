namespace Proje12_OOP_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BilgiAlma

            for (int i = 0; i < 6; i++)
            {


                Console.Write($"{i}. Öğrenci adı: ");
                ogrAd.Add = Console.ReadLine();
                Console.Write($"{i}. Öğrenci adı: ");
                string ogrSoyad = Console.ReadLine();
                Console.Write($"{i}. Öğrenci adı: ");
                int ogrId = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{i}. Öğrenci adı: ");
                int ogrNosu = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{i}. Öğrenci adı: ");
                int ogrYas = Convert.ToInt32(Console.ReadLine());

            }
            
            
            #endregion

            List<Bolum> bolums = new List<Bolum>()
            {
                new  Bolum(){Id=1 ,Aciklama="Mekatronik",Ogrenci= new List<Ogrenci>()
                    {
                    
                    new Ogrenci(){Ad=ogrAd,Soyad=ogrSoyad, Id=ogrId, OgrNo=ogrNosu,Yas=ogrYas},
                    new Ogrenci(){Ad=ogrAd,Soyad=ogrSoyad, Id=ogrId, OgrNo=ogrNosu,Yas=ogrYas},
                    new Ogrenci(){Ad=ogrAd,Soyad=ogrSoyad, Id=ogrId, OgrNo=ogrNosu,Yas=ogrYas},
                    }
                },
               new  Bolum(){Id=2 ,Ad="Bilgisayar",Aciklama="yok" ,Ogrenci= new List<Ogrenci>()
                    {

                    new Ogrenci(){Ad=ogrAd,Soyad=ogrSoyad, Id=ogrId, OgrNo=ogrNosu,Yas=ogrYas},
                    new Ogrenci(){Ad=ogrAd,Soyad=ogrSoyad, Id=ogrId, OgrNo=ogrNosu,Yas=ogrYas},
                    new Ogrenci(){Ad=ogrAd,Soyad=ogrSoyad, Id=ogrId, OgrNo=ogrNosu,Yas=ogrYas},
                    }
                }
            };

            foreach (var kisi in bolums)
            {
                Console.WriteLine($"Bolum Id: {kisi.Id} - Bolum Adı: {kisi.Ad} - Açıklama: {kisi.Aciklama}");

                foreach (var ogrn in kisi.Ogrenci)
                {
                    Console.WriteLine($"\tProduct Id: {product.Id} - Product Name: {product.Name} - Product Price: {product.Price}");
                }
                Console.WriteLine("*******************************************************");
            }

            Console.ReadLine();
        }
    }
}