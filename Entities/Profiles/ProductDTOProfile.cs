using AutoMapper;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Profiles
{
    public class ProductDTOProfile:Profile
    {
        public ProductDTOProfile()
        {
            CreateMap<ProductDTO, Product>();
        }
    }
}
