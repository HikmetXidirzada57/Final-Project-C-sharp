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
    public class EFCommentDal : EFEntityResopsitory<LexiconDBContext, Comment>, ICommentDal
    {
        public async Task<List<Comment>> GetAll()
        {
            using LexiconDBContext context = new LexiconDBContext();
            return  await context.Comments.ToListAsync();
        }

        public async Task<Comment> GetById(int id)
        {
            using LexiconDBContext context = new LexiconDBContext();
            return await context.Comments.
                FirstOrDefaultAsync(c=>c.Id==id && !c.IsDeleted);
        }
    }
}
