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
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _service;
        private readonly IMapper _mapper;

        public BlogController(IBlogService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<BlogController>
        [HttpGet("getAll")]
        public async Task<List<Blog>> GetAll()
        {
            return await _service.GetAllBlogs();
        }
        [HttpGet("getAllByCategory")]
        public async Task<List<Blog>> GetAllByCategory(int categoryId)
        {
            return await _service.GetBlogsByCategory(categoryId);
        }

        [HttpGet("getRelatedBlogs/{blogId}/{categoryId}")]
        public async Task<List<Blog>> GetRelateds(int? blogId,int? categoryId)
        {
            return await _service.GetBlogsRelated(blogId.Value, categoryId.Value);
        }
        // GET api/<BlogController>/5
        [HttpGet("{id}")]
        public async Task<Blog> Get(int? id)
        {
            if (id == null) return null;
            return await _service.GetById(id.Value);
        }

        // POST api/<BlogController>
        [HttpPost("Add")]
        public void Add([FromBody] BlogDTO blogDTO)
        {
            var _mapperBlog = _mapper.Map<BlogDTO>(blogDTO);
            _service.Add(_mapperBlog);
        }

        // PUT api/<BlogController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
