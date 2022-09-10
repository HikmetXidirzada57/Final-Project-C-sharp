using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(CategoryDTO category);
        void Update(Category category);
        void Remove(int id);
        public List<CategoryWithChildrenDTO> GetAll();
        public Task<List<Category>> GetCategoryWithParent();
        public List<CategoryListDTO> GetChildrenByParent(int parentId);
    }
}
