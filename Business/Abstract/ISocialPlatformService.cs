using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISocialPlatformService
    {
        Task<List<SocialPlatform>> GetAllPlatforms();
        Task<SocialPlatform> GetById(int id);
        void Add(SocialPlatformDTO socialPlatform);
        void Update(SocialPlatform socialPlatform);
        void Delete(SocialPlatform socialPlatform);
    }
}
