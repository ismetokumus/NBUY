using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IYazarRepository
    {
        List<Yazar> Yazarlistesi();
        void YazarEkle(Yazar yazar);
        void YazarGuncelle(Yazar yazar);
        void YazarSil(Yazar yazar);
        public Yazar YazarGetir(int id);
    }
}