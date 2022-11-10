using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje05_KatmanliMimari.DataAccessLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}

namespace Proje04_VeriErisimSinifi
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        
    }
}