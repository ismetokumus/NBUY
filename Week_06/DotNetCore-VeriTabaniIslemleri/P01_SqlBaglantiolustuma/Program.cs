using System.Data.SqlClient;

namespace P01_SqlBaglantiolustuma;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();


    }
    static void GetSqlConnection()
    {
        /*
            1.Adım
            ConnectionString oluşturmak
        */
        //karaktedrlerde hata var sa önene @ işareti koyuluyor.

        string connectionString="Server=DESKTOP-OFVK2FD;Database=Northwind; User Id=sa;Password=123";
        
        using (var connection = new SqlConnection(connectionString))
        {
            //connection nesnesi sadece bu scope içinde yaşayıp, scope bitişinde bellekten kaldırılmış olacak!
            try
            {
                connection.Open();
                System.Console.WriteLine("Bağlantı sağlandı.....");
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
