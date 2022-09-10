using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITagManager
    {
        public Task <List<Tag>> GetAllTags();
        void Add(TagDTO tag);
        void Remove(Tag tag);
        void Update(Tag tag);
    }
}
