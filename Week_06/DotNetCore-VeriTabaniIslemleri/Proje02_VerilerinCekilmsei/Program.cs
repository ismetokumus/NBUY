
using System.Data.SqlClient;

namespace Proje02_VerilerinCekilmsei;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
    }

    static void GetSqlConnection()
    {
        string connectionString = "Server=DESKTOP-OFVK2FD; Database=Northwind ; User=sa ; Password=123";
        using (var connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                System.Console.WriteLine("Bağlantı sağlandı.....");
                string queryString = "SELECT * FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int sayac=1;
                while (sqlDataReader.Read())
                {
                    System.Console.WriteLine($"Sıra : {sayac} - Name : {sqlDataReader[1]} - Price: {sqlDataReader[5]}");
                    sayac++;
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
