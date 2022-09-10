using Core.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EFEntityResopsitory<LexiconDBContext, Category>, ICategoryDal
    {
        public List<CategoryListDTO> GetAllByParent(int parentId)
        {
            using LexiconDBContext context = new LexiconDBContext();    
            var category =  context.Categories.Where(c => c.ParentCategoryId == parentId)
          .Select(c => new CategoryListDTO
          {
              Id = c.Id,
              PrentcategoryId = c.ParentCategoryId,
              Name = c.Name,
              IconUrl = c.IconUrl,
              
          }).ToList();
            return category;
        }


        public async Task<List<Category>> GetCategoriesWithParent()
        {
            using LexiconDBContext context = new LexiconDBContext();
            return await context.Categories.Where(c=>!c.IsDeleted).Include(c=>c.ParentCategory).ToListAsync();
        }

        public List<CategoryWithChildrenDTO> GetCategoryWithChildrens()
        {
            var categoryList = GetDTOCategories();

            return  categoryList.Where(c => c.PrentcategoryId == null)
                .Select(c => new CategoryWithChildrenDTO()
                {
                    CategoryId = c.Id,
                    CategoryName = c.Name,
                    Childrens = categoryList.Where(ch => ch.PrentcategoryId == c.Id
                     && ch.PrentcategoryId != null)
                }).ToList();
        }

        public List<CategoryListDTO> GetDTOCategories()
        {
                using LexiconDBContext context = new LexiconDBContext();
                return context.Categories.Select(c => new CategoryListDTO()
                {
                    Id=c.Id,
                    Name = c.Name,
                    PrentcategoryId = c.ParentCategoryId,
                }).ToList();

        }

    }
}
