using Core.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal:IEntityResopsitory<Category>
    {
        //void Add(Category category);
        //void Update(Category category);
        public Task<List<Category>> GetCategoriesWithParent();
        public List<CategoryListDTO> GetAllByParent(int parentId);
        public List<CategoryWithChildrenDTO> GetCategoryWithChildrens();
        public List<CategoryListDTO> GetDTOCategories();
        //public Task <Category> GetById(int id);

    }
}
