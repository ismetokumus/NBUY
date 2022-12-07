using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        //Categories özgü memberler burada olacak.(property, field, )
        //Örneğin Aşağıdakiler gibi:
        Category GetByIdWithProducts();
 
    }
}
