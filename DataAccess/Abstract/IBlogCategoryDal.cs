using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogCategoryDal : IEntityResopsitory<BlogCategory>
    {
        Task<List<BlogCategory>> GetAllBlogCategories();
        Task<BlogCategory> GetById(int id);
    }
}
