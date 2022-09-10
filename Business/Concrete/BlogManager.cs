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
    public class BlogManager : IBlogService
    {
        IBlogDal _dal;

        public BlogManager(IBlogDal dal)
        {
            _dal = dal;
        }

        public void Add(BlogDTO blog)
        {
            Blog blg = new()
            {
                Name = blog.Name,
                Description = blog.Description,
                BlogPicture = blog.BlogPicture,
                BlogCategoryId=blog.BlogCategoryId
            };
            _dal.Add(blg);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Blog>> GetAllBlogs()
        {
            return await _dal.GetBlogs();  
        }

        public async Task<List<Blog>> GetBlogsByCategory(int categoryId)
        {
            return await _dal.GetBlogByCategory(categoryId);
        }

        public async Task<List<Blog>> GetBlogsRelated(int blogId, int categoryId)
        {
            return await _dal.GetRelatedBlogs(blogId, categoryId);
        }

        public async Task<Blog> GetById(int id)
        {
            return await _dal.GetById(id);
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}
