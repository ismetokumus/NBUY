using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace Proje04_VeriErisimSinifi
{
    public interface IProductDAL
    {
        void CreateProduct(Product product);//Bu C-create
        List<Product> GetAllProducts();     // R-ead
        Product GetByIdProduct(int id);
        void UpdateProduct(Product product);// U-date
        void DeleteProduct(int id);         // D-elete

        List<Product> GetProductByCategory(string categoryName);
    }

    public class SqlproductDal : IProductDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=DESKTOP-OFVK2FD; Database=Northwind ; User=sa ; Password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
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

        public Product GetByIdProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
    }

    public class SqliteProductDAL : IProductDAL
    {
        private SqliteConnection GetSqliteConnection()
        {
            string connectionString="Data Source=northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products=new List<Product>();
            using (var connection = GetSqliteConnection())
            {
                try
                {
                    connection.Open();
                    string quaryString = "SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products";
                    SqliteCommand sqliteCommand=new SqliteCommand(quaryString, connection);
                    SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
                    while (sqliteDataReader.Read())
                    {
                        products.Add(new Product(){
                            Id=int.Parse(sqliteDataReader[0].ToString()),
                            Name = sqliteDataReader[1].ToString(),
                            Price = decimal.Parse(sqliteDataReader[2].ToString()),
                            Stock = int.Parse(sqliteDataReader[3].ToString())
                        });
                    }
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
                finally
                {
                    connection.Close();
                }

            }
            return products;
        }

        public Product GetByIdProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }

    
}
