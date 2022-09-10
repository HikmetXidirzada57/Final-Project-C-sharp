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
    public class EFBlogDal : EFEntityResopsitory<LexiconDBContext, Blog>, IBlogDal
    {
        public async Task<List<Blog>> GetBlogByCategory(int categoryId)
        {
            LexiconDBContext context = new LexiconDBContext();
            return await context.Blogs.Where(b => b.BlogCategoryId == categoryId && !b.IsDeleted).ToListAsync();
        }

        public async Task<List<Blog>> GetBlogs()
        {
            LexiconDBContext context = new LexiconDBContext();
            return await context.Blogs.Where(b=>!b.IsDeleted).Include(b => b.BlogCategorys).ToListAsync();
        }

        public async Task<Blog> GetById(int id)
        {
            LexiconDBContext context = new LexiconDBContext();
            return await context.Blogs.Include(b=>b.BlogCategorys).FirstOrDefaultAsync(b => !b.IsDeleted && id==b.Id);
        }

        public async Task<List<Blog>> GetRelatedBlogs(int blogId, int categoryId)
        {
            LexiconDBContext content = new LexiconDBContext();
            return await content.Blogs.Include(b => b.BlogCategorys).Where(b => b.Id != blogId && b.BlogCategoryId == categoryId && !b.IsDeleted).ToListAsync();
        }
    }
}
