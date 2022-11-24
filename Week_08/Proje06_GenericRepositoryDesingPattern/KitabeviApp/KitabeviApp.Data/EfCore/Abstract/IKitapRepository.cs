using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository : IGenericRepository<Kitap>
    {
        //�u an burada IGenerikRepositoryden gelen Kitap iin gelen CRUD metotlar� var .
        //E�er bir class IKitapRepository'den miras al�rsa, t�m bu CRUD
        //Buraya ayr�ca yaz�lacak metodlar (a�a��daki gibi) sadece kitap entitysine �zg� metodlar.
        List<Kategori> KategoriyeGoreKitapListesi(int id);
    }
}