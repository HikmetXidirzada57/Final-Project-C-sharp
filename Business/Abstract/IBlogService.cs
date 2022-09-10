using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        Task<Blog> GetById(int id);
        Task<List<Blog>> GetAllBlogs();
        Task<List<Blog>>GetBlogsByCategory(int categoryId);
        Task<List<Blog>> GetBlogsRelated(int blogId, int categoryId);
        void Add(BlogDTO blog);
        void Update(Blog blog);
        void Delete(int id);
    }
}
