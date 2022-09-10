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
    public class ProductSpecificationController : ControllerBase
    {

        private readonly IProductSpecificationService _service;
        private readonly IMapper _mapper;
        public ProductSpecificationController(IProductSpecificationService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // GET: api/<ProductSpecificationController>
        [HttpGet]
        public async Task<List<ProductSpesification>> GetAll()
        {
            return await _service.GetAll();
        }

        // GET api/<ProductSpecificationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductSpecificationController>
        [HttpPost]
        public void Add([FromBody] ProductSpesificationDTO psc)
        {
            var mapperPs = _mapper.Map<ProductSpesificationDTO>(psc);
            _service.Add(mapperPs);
        }

        // PUT api/<ProductSpecificationController>/5
        [HttpPut("update/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductSpecificationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
