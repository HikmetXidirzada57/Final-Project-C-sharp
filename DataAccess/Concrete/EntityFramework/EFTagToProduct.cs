using Core.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFTagToProduct : EFEntityResopsitory<LexiconDBContext, TagtoProduct>, ITagToProductDal
    {
        public async Task AddTagToProduct(int productId, List<int> tagIds)
        {
            using LexiconDBContext context = new LexiconDBContext();
            context.TagtoProducts.AddRangeAsync(tagIds.Select(c => new TagtoProduct { ProductId = productId, TagId = c }));
            await context.SaveChangesAsync(); 
        }
        public async Task<List<TagtoProduct>> GetAllTagtoProduct()
        {
            using LexiconDBContext context = new LexiconDBContext();
            return await context.TagtoProducts.ToListAsync();
        }
    }
}
