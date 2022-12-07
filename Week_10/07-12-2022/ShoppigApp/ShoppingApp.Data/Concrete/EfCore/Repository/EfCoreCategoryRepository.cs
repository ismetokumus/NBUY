using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repository
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopAppContext context) :base(context)
        {
            //buaya gelen context base classa gönderiliyor ve aynı zamanda sadece bu constructor içinde geçerli. ama bu classın bütününde henüz kullanılmaıyor. Eğer kullanısın istersek yapmamız gereken işlemler var.
        }
        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
