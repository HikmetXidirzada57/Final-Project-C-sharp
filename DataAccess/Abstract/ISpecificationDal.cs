using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISpecificationDal : IEntityResopsitory<Spesification>
    {
         public Task<List<Spesification>> GetAllSpec();
         public Task<Spesification>GetById(int id);    
    }
}
