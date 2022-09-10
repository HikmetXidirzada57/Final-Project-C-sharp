using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISpecificationService
    {
        void Add(SpecificationDTO spesification);
        void Update(SpecificationDTO spesification);
        void Delete(SpecificationDTO spesification);
        public Task<Spesification> Get(int id);
        Task<List<Spesification>>GetAll();
    }
}
