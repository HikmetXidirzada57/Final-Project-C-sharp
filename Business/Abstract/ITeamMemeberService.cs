using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamMemeberService
    {
        Task<List<TeamMember>> GetMembers();
        Task<TeamMember> GetTeamMemberById(int id);
        void Add(TeamMemberDTO member);
        void Update(TeamMember member);
        void Delete(int id);

    }
}
