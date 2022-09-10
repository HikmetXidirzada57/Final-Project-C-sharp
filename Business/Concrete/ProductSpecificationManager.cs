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
    public class ProductSpecificationManager : IProductSpecificationService
    {
        IProductSpecificationDal _dal;

        public ProductSpecificationManager(IProductSpecificationDal dal)
        {
            _dal = dal;
        }

        public void Add(ProductSpesificationDTO courseSpecifaction)
        {
            ProductSpesification psc = new()
            {
                ProductId = courseSpecifaction.ProductId,
                SpesificationId = courseSpecifaction.SpecificationId
            };
            _dal.Add(psc);
        }

        public async Task<List<ProductSpesification>> GetAll()
        {
           return await _dal.GetAll();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductSpesification courseSpecifaction)
        {
            throw new NotImplementedException();
        }
    }
}
