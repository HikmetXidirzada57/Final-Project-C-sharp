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
    public class BlogCategoryManager : IBlogCategoryService
    {
        IBlogCategoryDal _dal;

        public BlogCategoryManager(IBlogCategoryDal dal)
        {
            _dal = dal;
        }

        public void Add(BlogCategoryDTO blog)
        {
            BlogCategory category = new BlogCategory()
            {
                Name = blog.Name,
            };
            _dal.Add(category);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BlogCategory>> GetAll()
        {
            return await _dal.GetAllBlogCategories();
        }

        public async Task<BlogCategory> GetById(int id)
        {
            return await _dal.GetById(id);
        }

        public void Update(BlogCategory blog)
        {
            throw new NotImplementedException();
        }
    }
}
