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
    public class BlogCategoriesController : ControllerBase
    {

        IBlogCategoryService _service;
        IMapper _mapper;

        public BlogCategoriesController(IBlogCategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<BlogCategoriesController>
        [HttpGet("getAllBlogCategories")]
        public async Task<List<BlogCategory>> GetAll()
        {
            return await _service.GetAll();
        }

        // GET api/<BlogCategoriesController>/5
        [HttpGet("{id}")]
        public async Task<BlogCategory> Get(int? id)
        {
            return await _service.GetById(id.Value);
        }

        // POST api/<BlogCategoriesController>
        [HttpPost("Add")]
        public void Add([FromBody] BlogCategoryDTO blogDTO)
        {
            var _mapperBC=_mapper.Map<BlogCategoryDTO>(blogDTO);
            _service.Add(blogDTO);
        }

        // PUT api/<BlogCategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogCategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
