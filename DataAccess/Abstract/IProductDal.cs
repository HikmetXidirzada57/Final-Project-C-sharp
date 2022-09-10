using Core.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityResopsitory<Product>
    {
        public Task<Product> GetProductById(int id);
        public Task<List<Product>> GetProductByCategory(int categoryId); 
        public Task<List<Product>> GetAllInclude(Expression<Func<Product ,bool>>? filters);
        Task<List<Product>> GetFilteredProducts(FilteredProductItems item);
        Task<List<Product>> GetRelatedProducts(int? productId, int? categoryId);
        Task<List<Product>> GetDealofDay();
        public int ProductCount();
        public List<Product> ProductList();
        Task<Product> AddProduct(Product product);
        Task UpdateProduct(int id,Product product);

    }

}
