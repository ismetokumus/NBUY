using System.Transactions;

namespace Proje01_Class_Field_Property_Uygulama
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //Product claassımız olacak: name , Price, Description
            //İstenildiği kadar Product bilgisinin girilmesini sağlayacağız
            //Kaç adet product bilgisi girileceğini kullanıcı belirlsin.
            //Product ekleme işi bitince, eklemiş Product'lar listelensin.

            Console.Write("Kaç adet ürün gireceksiniz?: ");
            int adet = int.Parse(Console.ReadLine());
            Product[] products = new Product[adet];
            Product product;//forun içerisinden çıkarmamızın sebebi her seferinde tanımlama yapmamak için
            for (int i = 0; i < adet; i++)
            {
                product = new Product();

                Console.Write("Product Name: ");
                product.Name = Console.ReadLine();

                Console.Write("Price: ");
                product.Price = decimal.Parse(Console.ReadLine());

                Console.Write("Description: ");
                product.Description= Console.ReadLine();

                products[i] = product;

            }
            Console.WriteLine("Product Name\tPrice\tDescription");
            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.Name}\t{prd.Price}\t{prd.Description}");
            }
            */

            #region RastgeleDegerUreterek

            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "Galaxy A50", "HP Notebook", "MacBook Air M2", "Iphone 14 Plus", "LG 27 inç Monitör" };
            string[] descArray = { "İyidir", "Şaşırtıcıdır", "Heyecan vericidir", "Soluğunuzu keser", "Tırttır" };
            decimal[] oldPrice=new decimal[5];
            Random random=new Random();
            Console.Write("Yapılacak zam oranını giriniz: ");
            decimal oran=int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                product = new Product()
                {
                    Name = nameArray[random.Next(0, 5)],
                    Description = descArray[random.Next(0, 5)],
                    Price = random.Next(100, 1001)
                    
                };
                oldPrice[i] = product.Price;
                product.Price *= (1 + (oran / 100));

                products[i] = product;
            }
            Console.WriteLine("Product Name".PadRight(30)+"Old Price".PadRight(10)+"Price".PadRight(10)+"Description");
            int j = 0;
            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.Name.PadRight(30)}{oldPrice[j].ToString().PadRight(10)}{prd.Price.ToString().PadRight(10)}{prd.Description}");//PadRight consol ekranda boşluk bırakmak için kullanılırdı ve karakterler string olmalı.
                j++;
            }

            #endregion

        }

    }
}