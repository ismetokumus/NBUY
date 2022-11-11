using Proje05_KatmanliMimari.BusinessLayer;
using Proje05_KatmanliMimari.DataAccessLayer;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;


namespace Proje05_KatmanliMimari;
class Program
{
    static void Main(string[] args)
    {
        int sayi;
        do
        {
            Console.Clear();
            System.Console.WriteLine("Chose Database->");
            System.Console.WriteLine("1-Msql");
            System.Console.WriteLine("2-Sqlite");
            System.Console.WriteLine("0-Exit");
            System.Console.Write("Lütfen seçiminizi giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 1)
            {
                Menu(sayi);
                Console.ReadLine();
            }

            else if (sayi == 2)
            {
                Menu(sayi);
                Console.ReadLine();
            }
            else if (sayi != 0)
            {
                System.Console.WriteLine("Yanlış seçim yaptınız.");
            }

        } while (sayi != 0);

    }

    static void Menu(int dbType)
    {
        Console.Clear();
        string dbName= dbType==1 ? "MySql" : "SqLite";
        System.Console.WriteLine($"By {dbName} DataBase - Northwind");
        System.Console.WriteLine("-----------------------------");
        System.Console.WriteLine("1-Product List");
        System.Console.WriteLine("2-Customer List");
        System.Console.Write("Seçiminizi yapınız: ");
        int secim= int.Parse(Console.ReadLine());
        if (secim == 1)
        {
            if(dbType==1){
            ProductList(new SqlProductDAL());
            }else{
            ProductList(new SqliteProductDAL());

            }
        }
        else if(secim == 2)
        {   
            if (dbType == 1)
            {
            CustomerList(new SqlCustomerDAL()); 
            }else{
            CustomerList(new SqliteCustomerDAL());
            }
        }
    }
    

    static void CustomerList(ICustomerDAL customerDAL)
    {
        var customerManager = new CustomerManager(customerDAL);
        List<Customer> customers = customerManager.GetAllCustomer();
        foreach (var customer in customers)
        {
            Console.WriteLine($"Id: {customer.Id}, Company Name: {customer.Company}, City: {customer.City}, Country: {customer.Country}");
        }
    }
    static void ProductList(IProductDAL productDAL)
    {
        var productManager = new ProductManager(productDAL);
        List<Product> products = productManager.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
}

