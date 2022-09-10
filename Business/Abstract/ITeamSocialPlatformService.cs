using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamSocialPlatformService
    {
        Task<List<TeamMembertoPlatform>> GetTeamToSocialPlatforms();
        Task<TeamMembertoPlatform> GetById(int id);
        void Add(TeamMemToPlatfDTO teamMembertoPlt);
        void Update(TeamMembertoPlatform teamMembertoPlt);
        void Delete(int id);
            
    }
}
