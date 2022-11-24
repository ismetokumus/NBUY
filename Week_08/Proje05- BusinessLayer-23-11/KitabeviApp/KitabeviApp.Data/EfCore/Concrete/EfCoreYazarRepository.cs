using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreYazarRepository : IYazarRepository
    {
        public void YazarEkle(Yazar yazar)
        {
            using (var context = new KitabeviContext())
            {
                context.Yazarlar.Add(yazar);
                context.SaveChanges();
            }
        }

        public Yazar YazarGetir(int id)
        {
            throw new NotImplementedException();
        }

        public void YazarGuncelle(Yazar yazar)
        {
            throw new NotImplementedException();
        }

        public List<Yazar> Yazarlistesi()
        {
            using( var context = new KitabeviContext())
            {
                List<Yazar> sonuc = context.Yazarlar.ToList();
                return sonuc;
            }
        }

        public void YazarSil(Yazar yazar)
        {
            throw new NotImplementedException();
        }
    }
}