using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITeamMemToPlatformDal:IEntityResopsitory<TeamMembertoPlatform>
    {
        Task<List<TeamMembertoPlatform>> GetTeamMembertoPlatforms();
        Task<TeamMembertoPlatform> Get(int id);

    }
}
