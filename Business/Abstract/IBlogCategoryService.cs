using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogCategoryService
    {
        Task<List<BlogCategory>> GetAll();
        Task<BlogCategory> GetById(int id);
        void Add(BlogCategoryDTO blog);
        void Update(BlogCategory blog);
        void Delete(int id);    
    }
}
