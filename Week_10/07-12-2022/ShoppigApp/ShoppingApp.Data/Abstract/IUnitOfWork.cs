using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IUnitOfWork : IDisposable // nesne öldürme işlemi için  IDisposable kullandık
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        Task SaveAsync();
        void Save();
    }
}
