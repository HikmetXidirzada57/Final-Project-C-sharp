using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductSpecificationService
    {
       Task<List<ProductSpesification>> GetAll();
        void Add(ProductSpesificationDTO courseSpecifaction);
        void Remove(int id);
        void Update(ProductSpesification courseSpecifaction);
    }
}
