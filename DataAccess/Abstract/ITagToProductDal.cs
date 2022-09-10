﻿using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITagToProductDal:IEntityResopsitory<TagtoProduct>
    {
        public Task<List<TagtoProduct>> GetAllTagtoProduct();
        public Task AddTagToProduct(int productId,List<int> tagIds);

    }
}
