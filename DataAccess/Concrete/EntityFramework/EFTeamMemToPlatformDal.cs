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
    public class EFTeamMemToPlatformDal : EFEntityResopsitory<LexiconDBContext, TeamMembertoPlatform>, ITeamMemToPlatformDal
    {
        public async Task<TeamMembertoPlatform> Get(int id)
        {
            LexiconDBContext context = new LexiconDBContext();
            return await context.TeamMembertoPlatforms.FirstOrDefaultAsync(t=>t.Id==id);
        }

        public async Task<List<TeamMembertoPlatform>> GetTeamMembertoPlatforms()
        {
            LexiconDBContext context = new LexiconDBContext();
            return await context.TeamMembertoPlatforms.ToListAsync();
        }
    }
}
