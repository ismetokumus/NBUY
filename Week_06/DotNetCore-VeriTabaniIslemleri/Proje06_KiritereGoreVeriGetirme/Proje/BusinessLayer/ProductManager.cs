
using Proje.DataAccessLayer;
using Proje.DataAccessLayer.Entities;

namespace Proje.BusinessLayer
{
    public class ProductManager
    {   /*
        DEPENDENCY INJECTION
        private readonly IProductDAL _productDAL;
        public ProductManager(IProductDAL productDAL)
        {
            _productDAL=productDAL;
        }
        */
        private readonly IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL=productDAL;
        }
        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return _productDAL.GetAll();
        }

        public Product GetByIdProduct(int id)
        {
            return _productDAL.GetById(id);
        }

        public List<Product> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductByCategoryId(int id){
            return _productDAL.GetProductByCategoryId(id);
        }

        public List<Product> GetProductByCategoryName(string categoryName){
            return _productDAL.GetProductByCategoryName(categoryName);
        }
    }
    
}