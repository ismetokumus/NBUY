using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository : IGenericRepository<Kitap>
    {
        //Þu an burada IGenerikRepositoryden gelen Kitap iin gelen CRUD metotlarý var .
        //Eðer bir class IKitapRepository'den miras alýrsa, tüm bu CRUD
        //Buraya ayrýca yazýlacak metodlar (aþaðýdaki gibi) sadece kitap entitysine özgü metodlar.
        List<Kategori> KategoriyeGoreKitapListesi(int id);
    }
}