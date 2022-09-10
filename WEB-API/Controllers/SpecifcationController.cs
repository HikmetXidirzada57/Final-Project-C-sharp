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
    public class SpecifcationController : ControllerBase
    {

        private readonly ISpecificationService _service;
        private readonly IMapper _mapper;

        public SpecifcationController(ISpecificationService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<SpecifcationController>
        [HttpGet("getAll")]
        public async Task<List<Spesification>> GetAll()
        {
            return await _service.GetAll();
        }

        // GET api/<SpecifcationController>/5
        [HttpGet("{id}")]
        public async Task<Spesification> Get(int? id)
        {
            return await _service.Get(id.Value);
        }

        // POST api/<SpecifcationController>
        [HttpPost("Add")]
        public void Add([FromBody] SpecificationDTO spec)
        {
            var _mapperS=_mapper.Map<SpecificationDTO>(spec);
            _service.Add(spec);
        }

        // PUT api/<SpecifcationController>/5
        [HttpPut("update/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SpecifcationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
