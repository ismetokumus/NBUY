using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje12_OOP_Work_01
{
    interface IAday
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }
    public class Ogrenci : IAday
    {

        public int OgrNo { get; set; }

        public string Soyad { get; set; }
        public int Yas { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; }

    }
    public class Bolum:IAday
    {
        public string Aciklama { get; set; }
        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Ogrenci> Ogrenci { get; set; }
    }
}
