using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeDeneme_MVC_Efcore_CodeFirst.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        
        public Product Product { get; set; }

    }
}