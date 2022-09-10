using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductSpecificationDal:IEntityResopsitory<ProductSpesification>
    {
        public Task<List<ProductSpesification>> GetAll();
        public Task<ProductSpesification> GetById(int id);
    }
}
