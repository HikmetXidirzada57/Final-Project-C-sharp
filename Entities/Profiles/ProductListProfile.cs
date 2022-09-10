using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class ProductListProfile:Profile
    {
        public ProductListProfile()
        {
            CreateMap<Product, ProductListDTO>()
                .ForMember(
                    dest => dest.ProductTags,
                    opt => opt.MapFrom(src => src.ProductTags)
                )
              .ForMember(
                    dest => dest.CategoryName,
                    opt => opt.MapFrom(src => src.Category.Name)
                )
                .ForMember(
                    dest => dest.CategoryId,
                    opt => opt.MapFrom(src => src.Category.Id)
                );
                 //   .ForMember(
                 //   dest => dest.ProductSpesifications,
                 //   opt => opt.MapFrom(src => src.ProductSpesifications.Select(cs => new SpecificationDTO
                 //   {
                 //       Key = cs.Spesification.Key,
                 //       Value = cs.Spesification.Value
                 //   }))
                 //  )
                 //.ForMember(
                 //   dest => dest.ProductTags,
                 //   opt => opt.MapFrom(src => src.ProductTags.Select(cs => new TagDTO
                 //   {
                 //       Name = cs.Tag.Name,
                 //   }))
                 // );
        }
    }
}
