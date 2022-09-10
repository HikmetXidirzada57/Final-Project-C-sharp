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
    public class EFTeamMemberDal : EFEntityResopsitory<LexiconDBContext, TeamMember>, ITeamMemberDal
    {
        public async Task<List<TeamMember>> GetAll()
        {
            using LexiconDBContext context = new LexiconDBContext();
            return await context.TeamMembers.ToListAsync();
        }
         
        public Task<TeamMember> GetById(int id)
        {
            using LexiconDBContext context = new LexiconDBContext();
            return context.TeamMembers.FirstOrDefaultAsync();
        }
    }
}
