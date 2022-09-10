using Core.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSpecificationDal : EFEntityResopsitory<LexiconDBContext, Spesification>, ISpecificationDal
    {
        public async Task<List<Spesification>> GetAllSpec()
        {
           LexiconDBContext context=new LexiconDBContext();
            return await context.Spesifications.ToListAsync();
        }

        public async Task<Spesification> GetById(int id)
        {
           LexiconDBContext context=new LexiconDBContext();
            return await context.Spesifications.FirstOrDefaultAsync();
        }
    }
}
