using Core.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICommentDal:IEntityResopsitory<Comment>
    {
        Task<List<Comment>> GetAll();
        Task<Comment> GetById(int id); 
    }
}
