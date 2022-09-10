using AutoMapper;
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
    public class CategoryManager : ICategoryManager
    {

        private readonly ICategoryDal _dal;


        public CategoryManager(ICategoryDal dal)
        {
            _dal = dal;
        }

        public void Add(CategoryDTO category)
        {
            Category cate = new()
            {
                Name = category.Name,
                IconUrl = category.IconUrl,
                ParentCategoryId = category.ParentCategoryId,
                ModeifiedOn = DateTime.Now,
                PublishDate=DateTime.Now
            };
            _dal.Add(cate);
        }

        public void Remove(int id)
        {
            var category = _dal.Get(c => c.Id == id);
        }

        public List<CategoryWithChildrenDTO> GetAll()
        {
           return _dal.GetCategoryWithChildrens();
        }

        public async Task<List<Category>> GetCategoryWithParent()
        {
           return await _dal.GetCategoriesWithParent();
        }

        public List<CategoryListDTO> GetChildrenByParent(int parentId)
        {
            return  _dal.GetAllByParent(parentId);
        }


        public void Update(Category category)
        {
             _dal.Update(category); 
        }
    }
}
