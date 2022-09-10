using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDal _dal;

        public ProductManager(IProductDal dal)
        {
            _dal = dal;
        }

        public async Task<Product> AddProduct(Product product)
        {
            return await _dal.AddProduct(product);
        }

        public async void Remove(int id)
        {
          var product=await _dal.Get(p=>p.Id==id && !p.IsDeleted);
            if (product != null)
            {
                product.IsDeleted = true;   
               _dal.Update(product);
            }
        }

        public List<Product> GetAll()
        {
           return _dal.ProductList();
        }

        public async Task<List<Product>> GetAllByCategory(int categoryId)
        {
            return await _dal.GetProductByCategory(categoryId);
        }

        public async Task<Product> GetById(int id)
        {
          return await _dal.GetProductById(id);
        }

        public async Task Update(int id, Product product)
        {
            await _dal.UpdateProduct(id, product);
        }

        public async Task<List<Product>> ProductsWithFilter(FilteredProductItems items)
        {
           return await _dal.GetFilteredProducts(items);
        }

        public async Task<List<Product>> GetProductsWithSlider()
        {
            return await _dal.GetAllInclude(p => p.IsSlider);
        }

        public async Task<List<Product>> GetProductsIsRecommend()
        {
            return await _dal.GetAllInclude(p=>p.IsRecommend);
        }

        public async Task<List<Product>> GetProductsBestSeller()
        {
            return await _dal.GetAllInclude(p => p.IsBestSeller);
        }

        public async Task<List<Product>> GetDealofDay()
        {
            return await _dal.GetDealofDay();
        }

        public async Task<List<Product>> GetProductsRelated(int productId, int categoryId)
        {
            return await _dal.GetRelatedProducts(productId,categoryId);
        }

        public int GetProductCount()
        {
            return _dal.ProductCount();
        }
    }
}
