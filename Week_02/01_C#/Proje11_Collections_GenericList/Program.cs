namespace Proje11_Collections_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion

            //List<int> sayilar = new List<int>();
            //sayilar.Add(12);
            //sayilar.Add(128);
            //sayilar.Add(69);
            //sayilar.Add(28);
            //sayilar.Add(316);

            //List<string> isimler = new List<string>();
            //isimler.Add("Ali");
            //isimler.Add("Begüm");
            //isimler.Add("Kemal");

            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            //Console.WriteLine();
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //sayilar.Sort();
            //Console.WriteLine();
            //foreach (var sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            #endregion

            #region FirstSample

            //////Product product1 = new Product() { Id = 1, Name = "Bilgisayar", Price = 20_000 };
            //////Product product2 = new Product() { Id = 2, Name = "Telefon", Price = 18_000 };
            //////Product product3 = new Product() { Id = 3, Name = "Masa sandalye takımı", Price = 8_000 };

            ////// List<Product> products = new List<Product>() { product1, product2, product3 };

            //////List<Product> products = new List<Product>();
            //////products.Add(product1);
            //////products.Add(product2);
            //////products.Add(product3);

            ////List<Product> products = new List<Product>
            ////{
            ////    new Product(){Id=1, Name="Telefon",Price=19_000},
            ////    new Product(){Id=2, Name="Bilgisayar",Price=39_800},
            ////    new Product(){Id=3, Name="Masa Sandalye",Price=9_000}
            ////};

            //////Yeni bir liste yaratın adıda new product olsun içinede 3 yeni ürün bilgisi giriniz

            ////List<Product> newProducts = new List<Product>()
            ////{
            ////    new Product(){Id=4, Name="Mause",Price=175},
            ////    new Product(){Id=5, Name="Monitör",Price=1_750},
            ////    new Product(){Id=6, Name="Buzdolabı",Price=17_500}
            ////};

            //////newProducts içindeki prodactları, products içine ekleyeceğiz
            ////products.AddRange(newProducts);

            //////products.ForEach(p=>{
            //////     Console.WriteLine($"{p.Name}-{p.Price}");
            //////    Console.WriteLine();
            //////});

            ////int elemanSayisi = products.Count;


            ////products.Insert(0, new Product(){Id=21,Name="Gözlül",Price=1_200});

            ////products.InsertRange(3, newProducts);


            ////foreach (var product in products)
            ////{
            ////    Console.WriteLine($"{product.Name}-{product.Price}");
            ////}




            //////foreach (var product in products)
            //////{
            //////    Console.WriteLine($"{product.Name}-{product.Price}");
            //////}
            /////



            //List<Product> products = new List<Product>
            //{
            //    new Product(){Id=1, Name="Telefon",Price=19_000},
            //    new Product(){Id=2, Name="Bilgisayar",Price=39_800},
            //    new Product(){Id=3, Name="Masa Sandalye",Price=9_000}
            //};

            //ProductModel productModel = new ProductModel()
            //{
            //    Id = 1,
            //    CategoryName = "First Category",
            //    Products = products
            //};

            //Console.WriteLine(productModel.CategoryName);
            //foreach (var product in productModel.Products)
            //{
            //    Console.WriteLine($"\t{product.Name}");
            //}
            #endregion

            //İçinde 3 adet productModel tipinde veri barındıranbir list oluşturun
            //Her bir product model içinde ise,Products özelliğinde 3 er adet product koyun.

            List<ProductModel> productModels = new List<ProductModel>()
            {
                new  ProductModel(){Id=1,CategoryName="Bilgisayar",Products=new List<Product>()
                    {
                    new Product(){Id=1,Name="Ürün1",Price=500},
                    new Product(){Id=1,Name="Ürün2",Price=1500},
                    new Product(){Id=1,Name="Ürün3",Price=2500}
                    }
                }, 
                new  ProductModel(){Id=21,CategoryName="Telefonlar",Products=new List<Product>()
                    {
                    new Product(){Id=11,Name="Ürün4",Price=2500},
                    new Product(){Id=12,Name="Ürün5",Price=21500},
                    new Product(){Id=13,Name="Ürün6",Price=22500}
                    }
                },
                new  ProductModel(){Id=31,CategoryName="Mobilyalar",Products=new List<Product>()
                    {
                    new Product(){Id=21,Name="Ürün7",Price=3500},
                    new Product(){Id=22,Name="Ürün8",Price=31500},
                    new Product(){Id=23,Name="Ürün9",Price=32500}
                    }
                }
            };

            foreach (var productModel in productModels)
            {
                Console.WriteLine($"Product Model Id: {productModel.Id} - Category Name: {productModel.CategoryName}");
                  
                foreach (var product in productModel.Products)
                {
                    Console.WriteLine($"\tProduct Id: {product.Id} - Product Name: {product.Name} - Product Price: {product.Price}");
                }
                Console.WriteLine("*******************************************************");
            }

            Console.ReadLine();
        }
    }
}