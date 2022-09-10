using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _catManager;
        private readonly IMapper _mapper;
        public CategoryController(IMapper mapper, ICategoryManager catManager)
        {
            _mapper = mapper;
            _catManager = catManager;
        }

        // GET: api/<CategoryController>
        [HttpGet("getAllCategory")]
        public List<CategoryWithChildrenDTO> GetAllCategories()
        {
            return _catManager.GetAll();
        }

        [HttpGet("getchildrens/{parentId}")]
        public List<CategoryListDTO> GetChildrens(int? parentId)
        {
            if(parentId==null) return null;

            return  _catManager.GetChildrenByParent(parentId.Value);
        }

        [HttpGet("with-parent")]
        public async Task<List<CategoryWithParentDTO>> GetWithParent()
        {
            var categoryes = await _catManager.GetCategoryWithParent();
            var catMapper = _mapper.Map<List<CategoryWithParentDTO>>(categoryes);
            return catMapper;
        }
        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost("Add")]
        public void Add(CategoryDTO category)
        {
            category.ParentCategoryId = category.ParentCategoryId == 0 ? null : category.ParentCategoryId;
            var _mapperCat = _mapper.Map<CategoryDTO>(category);
            _catManager.Add(_mapperCat);

        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
