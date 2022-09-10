using AutoMapper;
using Business.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _service;
        private readonly IMapper _mapper;


        public CommentController(ICommentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        // GET: api/<CommentController>
        [HttpGet]
        public async Task<List<Comment>> Get()
        {
            return await _service.GetAllComments();
        }

        // GET api/<CommentController>/5
        [HttpGet("{id}")]
        public async Task<Comment> GetById(int? id)
        {
            return await _service.GetComment(id.Value);
        }

        // POST api/<CommentController>
        [HttpPost]
        public void Add([FromBody] CommentDTO comment)
        {
            var mapperComment=_mapper.Map<CommentDTO>(comment);
            _service.Add(mapperComment);
        }

        // PUT api/<CommentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
