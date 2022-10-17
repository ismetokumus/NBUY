using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje02_Methods
{
    internal class MethodOverload
    {
        public void DenemeMetodu()
        {
            Console.WriteLine("Merhaba. Ben MethodOverload classındayım");
            //Console.WriteLine(Program.Topla(3,5));
        }

        public int Topla(int s1,int s2,int s3=0)
        {
            return s1 + s2+ s3;
        }
        //Gönderilen 3 sayı arasında istersem çarpma, istersem toplama yapsın.

        // public int Islem(int s1, int s2, int s3 = 0,bool islemturu=true)//varsayılan parametler en başa yazılmalı
        public int Islem(bool islemturu,int s1, int s2, int s3 = 0)
        {
            if (islemturu == true)
            {
                return s1 + s2 + s3;
            }
            else
            {
                if (s3 == 0) s3 = 1;
                return s1 * s2 * s3;
            }
        }

        public int Topla(int[] sayilar)
        {
            int sonuc = sayilar.Sum();
            return sonuc;
        }
    }
}
