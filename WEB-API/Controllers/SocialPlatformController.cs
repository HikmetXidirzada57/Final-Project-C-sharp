
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
    public class SocialPlatformController : ControllerBase
    {
        private readonly ISocialPlatformService _service;
        private readonly IMapper _mapper;
        public SocialPlatformController(ISocialPlatformService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<SocialPlatformController>
        [HttpGet("getAllPlatform")]
        public async Task<List<SocialPlatform>> GetAll()
        {
            return await _service.GetAllPlatforms();
        }

        // GET api/<SocialPlatformController>/5
        [HttpGet("{id}")]
        public async Task<SocialPlatform> Get(int? id)
        {
            if (id == null) return null;
            return await _service.GetById(id.Value);
        }

        // POST api/<SocialPlatformController>
        [HttpPost("Add")]
        public void Add([FromBody] SocialPlatformDTO scp)
        {
            var _mapSp=_mapper.Map<SocialPlatformDTO>(scp);
            _service.Add(_mapSp);
        }

        // PUT api/<SocialPlatformController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SocialPlatformController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
