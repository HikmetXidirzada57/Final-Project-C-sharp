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
    public class SocialPlatformManager : ISocialPlatformService
    {
        ISocialPlatformDal _dal;

        public SocialPlatformManager(ISocialPlatformDal dal)
        {
            _dal = dal;
        }

        public void Add(SocialPlatformDTO socialPlatform)
        {
            SocialPlatform scp = new SocialPlatform()
            {
             Icon = socialPlatform.Icon,
            };
            _dal.Add(scp);
        }

        public void Delete(SocialPlatform socialPlatform)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SocialPlatform>> GetAllPlatforms()
        {
            return await _dal.GetSocialPlatforms();
        }

        public async Task<SocialPlatform> GetById(int id)
        {
            return await _dal.GetSocialPlatformById(id);
        }

        public void Update(SocialPlatform socialPlatform)
        {
            throw new NotImplementedException();
        }
    }
}
