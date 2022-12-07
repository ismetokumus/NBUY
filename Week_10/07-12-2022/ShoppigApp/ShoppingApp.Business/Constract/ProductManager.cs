using ShoppingApp.Business.Abstract;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Constract
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfwork;
        public ProductManager(IUnitOfWork unitOfwork)
        {
            _unitOfwork = unitOfwork;
        }

        #region Generics

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfwork.Products.GetByIdAsync(id);
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _unitOfwork.Products.GetAllAsync();
        }

        public async Task CreateAsync(Product product)
        {
            await _unitOfwork.Products.CreateAsync(product);
            await _unitOfwork.SaveAsync();
        }
        public void Update(Product product)
        {
            _unitOfwork.Products.Update(product);
            _unitOfwork.Save();
        }

        public void Delete(Product product)
        {
            _unitOfwork.Products.Delete(product);
            _unitOfwork.Save();
        }
        #endregion

        #region Products

        public async Task<List<Product>> GetHomePageProductsAsync()
        {
            return await _unitOfwork.Products.GetHomePageProductsAsync();
        }

        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
