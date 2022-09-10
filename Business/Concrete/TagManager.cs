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
    public class TagManager : ITagManager
    {

       private readonly ITagDal _dal;

        public TagManager(ITagDal dal)
        {
            _dal = dal;
        }

        public void Add(TagDTO tag)
        {
            Tag tg = new()
            {
                Name = tag.Name,
            };
            _dal.Add(tg);
        }
            
        public async Task<List<Tag>> GetAllTags()
        {
          return await _dal.GetAllTags();
        }

        public void Remove(Tag tag)
        {
            throw new NotImplementedException();
        }

        public void Update(Tag tag)
        {
            throw new NotImplementedException();
        }
    }
}
