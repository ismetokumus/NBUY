namespace Proje08_HataKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                //Normalde çalışmasını istediğimiz kodları yazıyoruz
                //Try bloğunda herhangi bir HATA var mı yok mu kontrol ediliyor
                //Eğer bir hata oluşursa CATCH bloğuna yönlendiriliyor
                Console.Write("1. Sayıyı giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı giriniz: ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                int sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
			catch (DivideByZeroException ex)
			{

                Console.WriteLine ("Sıfıra bölünme hatasu var!");
                //Console.WriteLine(ex.Message);
			}
            catch(OverflowException ex)
            {
                Console.WriteLine("Haddinden büyük bir sayı girdiniz!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu!");
            }
            finally
            {
                //Try ya da Catch bloklarından hangisi çalışırsa çalışsın ,her halükarda 
                //bu satıra gelecektir.
                Console.WriteLine("Program sona ermiştir!");

            }
        }
    }
}