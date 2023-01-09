//using Solid03_OpenClosed.Before;
using Solid03_OpenClosed.After;

namespace Solid03_OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before
            //Kare kare = new Kare(1);
            //Kare kare1 = new Kare(1);
            //Daire daire = new Daire(1);
            //object[] sekiller = new object[3] { kare, kare1, daire };
            //Hesapla hesapla = new Hesapla();

            //Console.WriteLine("Sonuç : " + hesapla.AlanlariTopla(sekiller));
            #endregion

            #region After
            Kare kare = new Kare(5);
            Kare kare1 = new Kare(3);
            Daire daire = new Daire(4);
            Sekil[] sekiller = new Sekil[3] { kare, kare1, daire };
            Hesapla hesapla = new Hesapla();

            Console.WriteLine("Sonuç : " + hesapla.AlanlariTopla(sekiller));
            #endregion

        }
    }
}