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
    public class TeamMemberController : ControllerBase
    {
        private readonly ITeamMemeberService _service;
        private readonly IMapper _mapper;

        public TeamMemberController(ITeamMemeberService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<TeamMemberController>
        [HttpGet("getAllMember")]
        public async Task<List<TeamMember>> GetAllMember()
        {
            return await _service.GetMembers();
        }

        // GET api/<TeamMemberController>/5
        [HttpGet("{id}")]
        public async Task<TeamMember> Get(int? id)
        {
            if (id == null) return null;
            return await _service.GetTeamMemberById(id.Value);
        }

        // POST api/<TeamMemberController>
        [HttpPost("Add")]
        public void Add([FromBody] TeamMemberDTO member)
        {
            var _mapperMember = _mapper.Map<TeamMemberDTO>(member);
            _service.Add(_mapperMember);
        }

        // PUT api/<TeamMemberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeamMemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
