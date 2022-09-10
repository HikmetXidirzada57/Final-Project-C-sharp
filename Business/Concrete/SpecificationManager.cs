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
    public class SpecificationManager : ISpecificationService
    {
        ISpecificationDal _dal;

        public SpecificationManager(ISpecificationDal dal)
        {
            _dal = dal;
        }

        public void Add(SpecificationDTO spesification)
        {
            Spesification sps = new()
            {
                Key = spesification.Key,
                Value = spesification.Value
            };
            _dal.Add(sps);
        }

        public void Delete(SpecificationDTO spesification)
        {
            throw new NotImplementedException();
        }

        public async Task<Spesification> Get(int id)
        {
            return await _dal.GetById(id);
        }

        public async Task<List<Spesification>> GetAll()
        {
            return await _dal.GetAllSpec();
        }

        public void Update(SpecificationDTO spesification)
        {
            throw new NotImplementedException();
        }
    }
}
