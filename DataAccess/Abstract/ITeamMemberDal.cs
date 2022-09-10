using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITeamMemberDal : IEntityResopsitory<TeamMember>
    {
        public Task<List<TeamMember>> GetAll();
        public Task<TeamMember> GetById(int id);
    }
}
