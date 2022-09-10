using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITagToProductManager
    {
        Task Add(int productId,List<int> tagIds);
        void Update(TagtoProduct category);
        void Remove(int id);
        public Task<List<TagtoProduct>> GetAll();
    }
}
