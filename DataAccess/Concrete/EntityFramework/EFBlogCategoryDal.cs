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
    public class EFBlogCategoryDal : EFEntityResopsitory<LexiconDBContext, BlogCategory>, IBlogCategoryDal
    {
        public async Task<List<BlogCategory>> GetAllBlogCategories()
        {
            LexiconDBContext context=new LexiconDBContext();
            return await context.BlogCategories.ToListAsync();
        }

        public async Task<BlogCategory> GetById(int id)
        {
            LexiconDBContext context=new LexiconDBContext();
           return await context.BlogCategories.FirstOrDefaultAsync(b=>b.Id==id);
        }
    }
}
