using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Proje05_KatmanliMimari.DataAccessLayer.Entities;

namespace Proje05_KatmanliMimari.DataAccessLayer
{
    public interface ICustomerDAL
    {
        void Create(Customer customer);//Bu C-create
        List<Customer> GetAll();     // R-ead
        Customer GetById(int id);
        void Update(Customer customer);// U-date
        void Delete(int id);         // D-elete
        
    }
    
}
