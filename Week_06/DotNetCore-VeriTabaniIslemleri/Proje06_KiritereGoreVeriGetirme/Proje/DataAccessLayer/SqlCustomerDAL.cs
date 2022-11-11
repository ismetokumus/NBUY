using System.Data.SqlClient;
using Proje.DataAccessLayer.Entities;

namespace Proje.DataAccessLayer
{
    public class SqlCustomerDAL : ICustomerDAL
    {
        private SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=DESKTOP-OFVK2FD; Database=Northwind ; User=sa ; Password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
        
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString = "SELECT CustomerID, CompanyName, City, Country FROM Customers";
                    SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        customers.Add(new Customer()
                        {
                            Id = sqlDataReader[0].ToString(),
                            Company = sqlDataReader[1].ToString(),
                            City = sqlDataReader[2].ToString(),
                            Country = sqlDataReader[3].ToString()
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

        public void Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

    
}
