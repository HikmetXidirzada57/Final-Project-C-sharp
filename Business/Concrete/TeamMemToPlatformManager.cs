using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeamMemToPlatformManager : ITeamSocialPlatformService
    {

        ITeamMemToPlatformDal _dal;

        public TeamMemToPlatformManager(ITeamMemToPlatformDal dal)
        {
            _dal = dal;
        }

        public void Add(TeamMemToPlatfDTO teamMembertoPlt)
        {
            TeamMembertoPlatform tmp = new()
            {
                TeamMemberId=teamMembertoPlt.TeamMemberId,
                PlatformId=teamMembertoPlt.PlatformId,
            };
            _dal.Add(tmp);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<TeamMembertoPlatform> GetById(int id)
        {
            return await _dal.Get(id);    
        }

        public async Task<List<TeamMembertoPlatform>> GetTeamToSocialPlatforms()
        {
            return await _dal.GetTeamMembertoPlatforms();
        }

        public void Update(TeamMembertoPlatform teamMembertoPlt)
        {
            throw new NotImplementedException();
        }
    }
}
