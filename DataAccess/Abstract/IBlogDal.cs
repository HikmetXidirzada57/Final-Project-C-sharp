using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDal:IEntityResopsitory<Blog>
    {
        Task<List<Blog>> GetBlogs();
        Task<Blog> GetById(int id);
        Task<List<Blog>> GetBlogByCategory(int categoryId);
        Task<List<Blog>> GetRelatedBlogs(int blogId,int categoryId);
        Task UpdateBlog(int id, Blog blog);

    }
}
