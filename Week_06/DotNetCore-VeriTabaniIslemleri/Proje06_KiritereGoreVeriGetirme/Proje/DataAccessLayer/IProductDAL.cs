using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Proje.DataAccessLayer.Entities;

namespace Proje.DataAccessLayer
{
    public interface IProductDAL
    {
        void Create(Product product);//Bu C-create
        List<Product> GetAll();     // R-ead
        Product GetById(int id);
        void Update(Product product);// U-date
        void Delete(int id);         // D-elete
        List<Product> GetProductByCategoryName(string categoryName);

        List<Product> GetProductByCategoryId(int id);
    }
    
}
