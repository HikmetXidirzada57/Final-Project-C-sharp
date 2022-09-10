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
    public class TeamMemberToPlatformController : ControllerBase
    {

        private readonly ITeamSocialPlatformService _service;
        private readonly IMapper _mapper;
        public TeamMemberToPlatformController(ITeamSocialPlatformService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<TeamMemberToPlatformController>
        [HttpGet("getAll")]
        public async Task<List<TeamMembertoPlatform>> Get()
        {
            return await _service.GetTeamToSocialPlatforms();
        }

        // GET api/<TeamMemberToPlatformController>/5
        [HttpGet("{id}")]
        public async Task<TeamMembertoPlatform> Get(int? id)
        {
            if (id == null) return null;
            return await _service.GetById(id.Value);
        }

        // POST api/<TeamMemberToPlatformController>
        [HttpPost]
        public void Add([FromBody] TeamMemToPlatfDTO dto)
        {
            var _mapperTP = _mapper.Map<TeamMemToPlatfDTO>(dto);
            _service.Add(_mapperTP);
        }

        // PUT api/<TeamMemberToPlatformController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamMemberToPlatformController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
