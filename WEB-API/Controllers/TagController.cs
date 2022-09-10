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
    public class TagController : ControllerBase
    {

        private readonly ITagManager _tagManager;
        private readonly IMapper _mapper;
        public TagController(ITagManager tagManager, IMapper mapper)
        {
            _tagManager = tagManager;
            _mapper = mapper;
        }

        // GET: api/<TagController>
        [HttpGet("getAll")]
        public async Task<List<Tag>> Get()
        {
            return await _tagManager.GetAllTags(); 
        }

        // GET api/<TagController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TagController>
        [HttpPost("Add")]
        public void Post([FromBody] TagDTO tagDTO)
        {
            var _mapperTag =_mapper.Map<TagDTO>(tagDTO);

            _tagManager.Add(_mapperTag);
        }

        // PUT api/<TagController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TagController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
