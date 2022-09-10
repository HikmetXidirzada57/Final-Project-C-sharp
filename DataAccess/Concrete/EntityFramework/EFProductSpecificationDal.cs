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
    public class EFProductSpecificationDal : EFEntityResopsitory<LexiconDBContext, ProductSpesification>, IProductSpecificationDal
    {
        public async Task<List<ProductSpesification>> GetAll()
        {
           LexiconDBContext context=new LexiconDBContext();
            return await  context.ProductSpesifications.ToListAsync();
        }

        public async Task<ProductSpesification> GetById(int id)
        {
           LexiconDBContext context=new LexiconDBContext();
            return await context.ProductSpesifications.FirstOrDefaultAsync();
        }
    }
}
