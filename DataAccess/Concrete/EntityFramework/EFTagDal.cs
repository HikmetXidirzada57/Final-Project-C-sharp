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
    public class EFTagDal : EFEntityResopsitory<LexiconDBContext, Tag>, ITagDal
    {
        public async Task<List<Tag>> GetAllTags()
        {
            using LexiconDBContext context = new LexiconDBContext();
            return await context.Tags.Where(t =>!t.IsDeleted).ToListAsync();
        }
    }
}
