using Core.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : EFEntityResopsitory<LexiconDBContext, Product>, IProductDal
    {
        public async Task<Product> AddProduct(Product product)
        {
            using LexiconDBContext context = new LexiconDBContext();
            var newProduct= await context.Products.AddAsync(product);
           await context.SaveChangesAsync();
            return newProduct.Entity;
        }

        public async Task<List<Product>> GetAllInclude(Expression<Func<Product, bool>>? filters)
        {
            using LexiconDBContext context = new LexiconDBContext();
            var product= context.Products.Include(p=>p.Category).
            Where(p => !p.IsDeleted).
            AsQueryable();

            if (filters != null)
            {
                product = product.Where(filters);
            }
            return await product.ToListAsync();
        }

        public async Task<List<Product>> GetDealofDay()
        {
            using LexiconDBContext context = new LexiconDBContext();
            var deal = await context.Products.Include(p=>p.Category).Where(p => !p.IsDeleted && p.Dicount>0 && p.Dicount!=null).OrderByDescending(p => p.Price).Take(2).ToListAsync();
            return deal;
        }

        public async Task<List<Product>> GetFilteredProducts(FilteredProductItems item)
        {
            using LexiconDBContext context = new();
            var products = context.Products.
                Include(p => p.Category).Where(p => !p.IsDeleted).
                AsQueryable();
            if(!string.IsNullOrWhiteSpace(item.Q) && item.Q != null)
            {
                products=products.Where(p=>p.Name.ToLower().Contains(item.Q)
                || p.Category.Name.Contains(item.Q));
            }
            if (item.Rating.HasValue)
            {
                products = item.Rating.Value switch
                {
                    1 => products.Where(p => p.Rating >=1 && p.Rating < 2),
                    2 => products.Where(p => p.Rating >=2 && p.Rating < 3),
                    3 => products.Where(p => p.Rating >=3 && p.Rating < 4),
                    4 => products.Where(p => p.Rating >=4 && p.Rating < 5),
                    5=> products.Where(p=>p.Rating==5),
                    _ => products.Where(p=>p.Rating >=1 && p.Rating<=5),
                };
            }

            if (item.SortBy.HasValue)
            {
                products = item.SortBy.Value switch
                {
                    0 => products.OrderByDescending(c => c.Price),
                    1 => products.OrderBy(c => c.Price),
                    _ => products.OrderBy(c => c.PublishDate),
                };
            }
            return await products.ToListAsync();
        }

        public async Task<List<Product>> GetProductByCategory(int categoryId)
        {
            using LexiconDBContext context = new LexiconDBContext();
            return await context.Products  
                .Where(p => !p.IsDeleted && p.CategoryId == categoryId).
                Include(p => p.Category).ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            using LexiconDBContext context = new LexiconDBContext();
            var product= context.Products
                .Include(p => p.Category).
                 Include(p => p.ProductSpesifications).
                ThenInclude(p => p.Spesification)
                 .Include(p => p.ProductTags)
                .ThenInclude(c => c.Tag)
                .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);
            return await product;
        }

        public async Task<List<Product>> GetRelatedProducts(int? productId, int? categoryId)
        {
            LexiconDBContext context = new LexiconDBContext();
            return await context.Products.Where(p => p.Id != productId && p.CategoryId == categoryId).ToListAsync();
        }

        public int ProductCount()
        {
            LexiconDBContext context = new LexiconDBContext();
            return context.Products.Where(x => !x.IsDeleted).Count();
        }

        public List<Product> ProductList()
        {
            using LexiconDBContext context = new LexiconDBContext();
            var products = context.Products.
                Include(p=>p.Category).
                 Include(p => p.ProductSpesifications)
                .ThenInclude(p => p.Spesification)
                .Include(p => p.ProductTags)
                .ThenInclude(c=>c.Tag)
                .Where(p=>!p.IsDeleted).ToList();

            return products;
        }

        public async Task UpdateProduct(int id,Product product)
        {
            using LexiconDBContext context = new();
            context.Products.Update(product);
            await context.SaveChangesAsync();
        }
    }
}
