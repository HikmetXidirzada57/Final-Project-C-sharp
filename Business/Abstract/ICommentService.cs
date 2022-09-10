using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        Task<List<Comment>> GetAllComments();
        Task<Comment> GetComment(int id);
        void Add(CommentDTO comment);
        void Update(Comment comment);
        void Delete(int id);
    }
}
