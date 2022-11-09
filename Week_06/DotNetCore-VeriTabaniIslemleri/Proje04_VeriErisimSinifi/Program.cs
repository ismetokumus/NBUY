
using System.Data.SqlClient;

namespace Proje04_VeriErisimSinifi;
class Program
{
    static void Main(string[] args)
    {
        int sayi;
        do
        {
            Console.Clear();
            System.Console.Write("Lstelenmesini istediğinizi seçiniz? Product(1)-Customers(2)-Çıkış için(0)");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 1)
            {
                List<Product> products = GetAllProducts();
                foreach (var product in products)
                {
                    System.Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
                
            }
            else if (sayi == 2)
            {
                List<Customer> customers = GetAllCustomers();
                foreach (var customer in customers)
                {
                    System.Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, City: {customer.City}, ");
                }
            }
            else if (sayi != 0)
            {
                System.Console.WriteLine("Yanlış seçim yaptınız.");
            }
            Console.ReadLine();
        } while (sayi != 0);

    }
    static List<Product> GetAllProducts()
    {
        List<Product> products = new List<Product>();
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    products.Add(new Product()
                    {
                        Id = int.Parse(sqlDataReader[0].ToString()),
                        Name = sqlDataReader[1].ToString(),
                        Price = decimal.Parse(sqlDataReader[2].ToString()),
                        Stock = int.Parse(sqlDataReader[3].ToString())
                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                System.Console.WriteLine("Bir sorun oluştu!!!");
            }
            finally
            {
                connection.Close();
            }
        }
        return products;
    }
    static List<Customer> GetAllCustomers()
    {
        List<Customer> customers = new List<Customer>();
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT CustomerID, ContactName, City FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    customers.Add(new Customer()
                    {
                        Id = sqlDataReader["CustomerId"].ToString(),//sqlDataReader[0] bu şekildede olabilir
                        Name = sqlDataReader[1].ToString(),
                        City = sqlDataReader[2].ToString()
                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {
                System.Console.WriteLine("Bir sorun oluştu!!!");
            }
            finally
            {
                connection.Close();
            }
        }
        return customers;
    }
    static SqlConnection GetSqlConnection()
    {
        string connectionString = "Server=DESKTOP-OFVK2FD; Database=Northwind ; User=sa ; Password=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;
    }
}
