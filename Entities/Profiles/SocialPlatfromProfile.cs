using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class SocialPlatfromProfile:Profile
    {
        public SocialPlatfromProfile()
        {
            CreateMap<SocialPlatformDTO, SocialPlatform>();
        }
    }
}
