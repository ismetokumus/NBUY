﻿using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repository
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product>, IProductRepository
    {
        public EfCoreProductRepository(ShopAppContext context) : base(context)
        { 

        }
        public List<Product> GetHomePageProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }
    }
}
