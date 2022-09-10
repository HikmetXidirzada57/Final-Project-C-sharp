using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class ProductDetailProfile : Profile
    {
        public ProductDetailProfile()
        {
            CreateMap<ProductDetailDTO, Product>()
                .ForMember(
                    dest => dest.ProductTags,
                    act => act.Ignore());
        }
    }
}
