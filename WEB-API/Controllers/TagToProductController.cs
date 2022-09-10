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
    public class TagToProductController : ControllerBase
    {
        private readonly ITagToProductManager _tgpManager;
        private readonly IMapper _mapper;

        public TagToProductController(ITagToProductManager tgpManager, IMapper mapper)
        {
            _tgpManager = tgpManager;
            _mapper = mapper;
        }

        // GET: api/<TagToProductController>
        [HttpGet("GetAllttP")]
        public async Task<List<TagtoProduct>> GetALL()
        {
            return await _tgpManager.GetAll();
        }

        // GET api/<TagToProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TagToProductController>
        [HttpPost("Add")]
        public void Add([FromBody] TagToProductDTO ttpDto)
        {
            var _mapperTag = _mapper.Map<TagToProductDTO>(ttpDto);

            //_tgpManager.Add(_mapperTag);
        }

        // PUT api/<TagToProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TagToProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
