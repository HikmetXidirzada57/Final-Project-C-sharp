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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _dal;

        public CommentManager(ICommentDal dal)
        {
            _dal = dal;
        }

        public void Add(CommentDTO comment)
        {
            Comment coment = new()
            {
                Description = comment.Description,
            };
            _dal.Add(coment);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Comment>> GetAllComments()
        {
            return await _dal.GetAll();
        }

        public async Task<Comment> GetComment(int id)
        {
            return await _dal.GetById(id);
        }

        public void Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
