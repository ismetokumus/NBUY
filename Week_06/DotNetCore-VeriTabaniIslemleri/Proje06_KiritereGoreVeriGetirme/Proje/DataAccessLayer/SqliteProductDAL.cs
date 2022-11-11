using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;

namespace Proje.DataAccessLayer

{
    public class SqliteProductDAL : IProductDAL
    {
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
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

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        private SqliteConnection GetSqliteConnection()
        {
            string connectionString="Data Source=northwind.db";
            SqliteConnection sqliteConnection = new SqliteConnection(connectionString);
            return sqliteConnection;
        }

        public List<Product> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategoryId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategoryName(string categoryName)
        {
            throw new NotImplementedException();
        }
    }

    
}
