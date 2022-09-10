using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITagDal:IEntityResopsitory<Tag>
    {
        public Task<List<Tag>> GetAllTags();
    }
}
