using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {
        static void yazdir(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 54, 12, 66, 34, 19 };
            Console.WriteLine("Defoult Sıra.");
            yazdir(sayilar);
            sayilar.Sort();
            Console.WriteLine("*************");
            Console.WriteLine("Küçükten büyüğe sıralı");
            yazdir(sayilar);
            Console.WriteLine("*************");
            Console.WriteLine("Büyükten küçüğe sıralı");
            sayilar.Reverse();
            yazdir(sayilar);














            //ArrayList myList=new ArrayList();
            //myList.Add(120);
            //myList.Add("120");
            //myList.Add("Zeynep");
            //myList.Add(11.5);
            //myList.Add(DateTime.Now);
            //myList.Add(false);

            //myList.Insert(0, "Yeni eleman");

            //ArrayList addetList = new ArrayList() { "Ayşen Umay", "Fercan Sercan", "Kazım Kolkanat" };

            //myList.InsertRange(4, addetList);
            //myList.AddRange(addetList);

            ////myList.Remove("120");
            ////myList.RemoveAt(0);
            ////myList.RemoveRange(0, 3);



            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //if (myList.Contains("Zeynep")==true)
            //{
            //    Console.WriteLine("Evet, Zeynep listede mevcut!");
            //}
            //else
            //{
            //    Console.WriteLine("Acil, Zeynepe haber ver! Listede yok!");
            //}

            //Console.WriteLine();
            ////Console.WriteLine(myList[3]);

            Console.ReadLine();
        }
    }
}