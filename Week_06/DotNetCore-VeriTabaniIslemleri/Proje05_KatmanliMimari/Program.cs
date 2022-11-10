using Proje05_KatmanliMimari.BusinessLayer;
using Proje05_KatmanliMimari.DataAccessLayer;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;
using System.Data.SqlClient;

namespace Proje05_KatmanliMimari;
class Program
{
    static void Main(string[] args)
    {
        int sayi;
        do
        {
            
            System.Console.Write("Listelenmesini istediğinizi seçiniz? Product(1)-Customers(2)-Çıkış için(0)");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 1)
            {
                // var productManager = new ProductManager(new SqlproductDal());
                // List<Product> products = productManager.GetAllProducts();
                ProductList();
                // foreach (var product in products)
                // {
                //     System.Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                    
                // }
                Console.ReadLine();
            }

            else if (sayi == 2)
            {
                // List<Customer> customers = GetAllCustomers();
                // foreach (var customer in customers)
                // {
                //     System.Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, City: {customer.City}, ");
                //     Console.ReadLine();
                // }
                Console.ReadLine();
            }
            else if (sayi != 0)
            {
                System.Console.WriteLine("Yanlış seçim yaptınız.");
            }
            
        } while (sayi != 0);

    }

    // static List<Customer> GetAllCustomers()
    // {
    //     List<Customer> customers = new List<Customer>();
    //     using (var connection = GetSqlConnection())
    //     {
    //         try
    //         {
    //             connection.Open();
    //             string queryString = "SELECT CustomerID, ContactName, City FROM Customers";
    //             SqlCommand sqlCommand = new SqlCommand(queryString, connection);
    //             SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    //             while (sqlDataReader.Read())
    //             {
    //                 customers.Add(new Customer()
    //                 {
    //                     Id = sqlDataReader["CustomerId"].ToString(),//sqlDataReader[0] bu şekildede olabilir
    //                     Name = sqlDataReader[1].ToString(),
    //                     City = sqlDataReader[2].ToString()
    //                 });
    //             }
    //             sqlDataReader.Close();
    //         }
    //         catch (Exception)
    //         {
    //             System.Console.WriteLine("Bir sorun oluştu!!!");
    //         }
    //         finally
    //         {
    //             connection.Close();
    //         }
    //     }
    //     return customers;
    // }
    static void ProductList()
    {
        var productManager = new ProductManager(new SqliteProductDAL() );
        List<Product> products = productManager.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
        }
    }
}

