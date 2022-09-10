using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Concrete.EntityFramework
{
    public class TagToProductManager : ITagToProductManager
    {
        ITagToProductDal _dal;

        public TagToProductManager(ITagToProductDal dal)
        {
            _dal = dal;
        }

        public async Task Add(int productId,List<int>tagIds) 
        {
            await _dal.AddTagToProduct(productId,tagIds);
        }

        public async Task<List<TagtoProduct>> GetAll()
        {
           return await _dal.GetAllTagtoProduct();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TagtoProduct category)
        {
            throw new NotImplementedException();
        }
    }
}
