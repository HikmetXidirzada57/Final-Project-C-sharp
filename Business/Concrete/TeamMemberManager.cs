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
    public class TeamMemberManager : ITeamMemeberService
    {
        private readonly ITeamMemberDal _dal;

        public TeamMemberManager(ITeamMemberDal dal)
        {
            _dal = dal;
        }

        public void Add(TeamMemberDTO member)
        {
            TeamMember team = new()
            {
                Name = member.Name,
                PhotoUrl = member.PhotoUrl,
                Speciality=member.Speciality,
            };
            _dal.Add(team);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TeamMember>> GetMembers()
        {
            return await _dal.GetAll();
        }

        public async Task<TeamMember> GetTeamMemberById(int id)
        {
            return await _dal.GetById(id);
        }

        public void Update(TeamMember member)
        {
            throw new NotImplementedException();
        }
    }
}
