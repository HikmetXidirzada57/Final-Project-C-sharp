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
    public class EFSocialPlatformDal : EFEntityResopsitory<LexiconDBContext, SocialPlatform>, ISocialPlatformDal
    {
        public async Task<SocialPlatform> GetSocialPlatformById(int id)
        {
            LexiconDBContext context=new LexiconDBContext();
            return await context.SocialPlatforms.FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        }

        public async Task<List<SocialPlatform>> GetSocialPlatforms()
        {
            LexiconDBContext context = new LexiconDBContext(); 
            return await context.SocialPlatforms.ToListAsync();
        }
    }
}
