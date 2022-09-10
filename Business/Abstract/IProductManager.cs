using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductManager
    {
        List<Product> GetAll();
        Task<List<Product>> GetAllByCategory(int categoryId);
        Task<List<Product>>? ProductsWithFilter(FilteredProductItems items);
        Task<List<Product>> GetProductsWithSlider();
        Task<List<Product>> GetProductsIsRecommend();
        Task<List<Product>> GetProductsBestSeller();
        Task<List<Product>> GetProductsRelated(int productId,int categoryId);
        public int GetProductCount();
        Task<List<Product>> GetDealofDay();
        Task<Product> GetById(int id);
        Task<Product> AddProduct(Product product);
        Task Update(int id,Product product);
        void Remove(int id);

    }
}
