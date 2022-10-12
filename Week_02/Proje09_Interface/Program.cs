namespace Proje09_Interface
{
    /*Interface ler için belirtilmediğinde defoult erişim belirleyici publictir.
     * Interfaceler protected private static olarak işaretlenemezler.
     * Interfaceler içinde çalışabilir kodlar olamaz sadece imzası bulunur.
     * Bir ınterface, bir ya da daha fazla ınterfaceden miras alabilir.
     * Bir ınterface class dan miras alamaz.
     * Eğer bir class bir ınterfaceden miras alıyorsa miras aldığı ınterfcadeki  tüm metodları implemente etmek zorundadır.(Implemente : Miras alınan ınterfacede imzası bulunan tüm metodların, içi dolu halleri.)
     */
    interface IPersonel
    {
        public string Departman { get; set; }
    }
    interface IKisi//interface başında "I" ile başla
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        
        public string Maas { get; set; }
        public void Bilgi();//Interface içindeki metodlarda sadece İMZA bulunur , metodun gövdesi olmaz!
        //Metod gövdesi, bu ınterfacei miras alan CLASS içinde doldurulur.
        //İnterface new yapılamaz!
    }
    //class iki klastan veri alamazken 2 adet interface den veri alınabilir.
    class Yonetici : IKisi,IPersonel
    {
        /// <summary>
        /// Bu method, herhngi bir yönetici bilgisi girmeden yönetici oluşturur.
        /// </summary>
        public Yonetici()
        {
            //Kimi zaman adSoya,adres ,maas ve depertman bilgisini vermeden 
        }
        /// <summary>
        /// Bu method, AdSoyad, Adres, Maas ve Depertman bilgileri girilerek Yönetici oluşturur.
        /// </summary>
        /// <param name="adSoyad"></param>
        /// <param name="adres"></param>
        /// <param name="maas"></param>
        /// <param name="departman"></param>
        public Yonetici(string adSoyad, string adres, string maas, string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }
    
        public string AdSoyad { get; set ; }
        public string Adres { get; set; }
        public string Maas { get; set; }
        public string Departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"Ad Soyad: {AdSoyad} Dpertman: {Departman} ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir abstarct classtan, miras alan classra
             * Eğer base class da abstract bir metod varsa , mutlaka override edilmeli
             * Eğer base class ta abstract olmaya methodlar varsa onlar aynen kullanılabilir
             * Ancak bazen, miras alınan classtaki her metodun, içinin dolu hallerini yazmak zorunlu olsun isteriz
             * Yani bir nevi hepsi abstract olsun isteriz. Bunu yapmak yerine, miras alınan classı,class değil Interface şeklinde tanımlarız!
             * */

            //IPersonel personel = new IPersonel(); //Hatalı kullanım

            //Yonetici yonetici1 =new Yonetici();
            //Yonetici yonetici2=new Yonetici("Alex de Souza","Rio de Jenerio","5000","Futbol");

            Product product1 = new Product()
            {
                Id = 1,
                Name = "Iphone 13",
                Price = 5900,
                Properties = "8 gb ram",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now

            };
            Console.WriteLine($"Product Name: {product1.Name}(Büyük harf: {product1.NameToUpper(product1.Name)}) Properties: {product1.Properties}");

            Category category1 = new Category()
            {
                Id = 1,
                Name = "Telefon",
                CreatedDate = DateTime.Now,
                Description = "Bu kategori telefonlar içindir."
            };
            Console.WriteLine($"Category Name: {category1.Name}");
            Console.ReadLine();
        }
    }
}