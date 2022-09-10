﻿using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISocialPlatformDal:IEntityResopsitory<SocialPlatform>
    {
        Task<SocialPlatform> GetSocialPlatformById(int id);
        Task<List<SocialPlatform>> GetSocialPlatforms();
    }
}
