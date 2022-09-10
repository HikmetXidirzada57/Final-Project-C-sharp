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
    
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _prmanager;
        private readonly IMapper _mapper;
        private readonly ITagToProductManager _tagToProductManager;
        public ProductController(IProductManager prmanager, IMapper mapper, ITagToProductManager tagToProductManager)
        {
            _prmanager = prmanager;
            _mapper = mapper;
            _tagToProductManager = tagToProductManager;
        }

        // GET: api/<ProductController>
        [HttpGet("getAll")]
        public List<ProductListDTO> GetAllProduct(int? currentPage,int? recordSize)
        {
            var listPro = _prmanager.GetAll();
            var proMapper= _mapper.Map<List<ProductListDTO>>(listPro);
            //var pr = new ProductListFilter
            //{
            //    Products = proMapper, 
            //    PageNo = currentPage,
            //};

            //pr.MaxPage = _prmanager.GetProductCount();
            //pr.Pager = new Pager(pr.MaxPage, pr.PageNo, recordSize.Value, 3);

            return proMapper;
        }
        [HttpGet ("by/{categoryId}")]
        public async Task<List<ProductListDTO>> GetProductsByCategory(int? categoryId)
        {
            if (!categoryId.HasValue) return null;
            var listPro = await _prmanager.GetAllByCategory(categoryId.Value);
            var proMapper = _mapper.Map<List<ProductListDTO>>(listPro);
            return proMapper;
        }



        [HttpGet("getSlider")]
        public async Task<List<Product>> GetAllProductWithSlider()
        {
            var productS = await _prmanager.GetProductsWithSlider();
            return productS;
        }

        [HttpGet("getIsRecommend")]
        public async Task<List<Product>> GetAllProductIsRecommended()
        {
            var productR = await _prmanager.GetProductsIsRecommend();
            return productR;
        }

        [HttpGet("dealofDay")]
        public async Task<List<Product>> GetAllDaysProduct()
        {
            var productR = await _prmanager.GetDealofDay();
            return productR;
        }

        [HttpGet("getIsBestSeller")]
        public async Task<List<Product>> GetAllProductBestSelled()
        {
            var productB = await _prmanager.GetProductsBestSeller();
            return productB;
        }


        [HttpGet("getRelated/{productId}/{categoryId}")]
        public async Task<List<Product>> GetAllProductRelated(int? productId,int? categoryId)
        {
            var productR = await _prmanager.GetProductsRelated(productId.Value,categoryId.Value);
            return productR;
        }
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int? id)
        {
            if(id==null) return null;
            var product = await _prmanager.GetById(id.Value);
            return  product;
        }

        [HttpPost("filter")]
        public async Task<ProductListFilter>? GetProductsFiltered([FromBody] FilteredProductItems items)
        {
            var productList = await _prmanager.ProductsWithFilter(items);
            int recordSize = 4;
            var allProduc = _prmanager.GetAll();
            var proMapper = _mapper.Map<List<ProductListDTO>>(productList);
            var pr = new ProductListFilter
            {
                Products = proMapper,
                MaxPrice = allProduc.Max(p => p.Price),
            };
        
            return pr;
        }
        // POST api/<ProductController>
        [HttpPost]
        public async Task<JsonResult> Add(ProductDetailDTO product)
        {
            JsonResult res = new(new { });
            try
            {
                var _mapperProduct = _mapper.Map<ProductDetailDTO,Product>(product);
               Product newProduct= await  _prmanager.AddProduct(_mapperProduct);

                await _tagToProductManager.Add(newProduct.Id, product.ProductTags);
                res.Value = new { status = 200, success = product.Name + " added successfully!" };
            }
            catch (Exception e)
            {
                res.Value = new { status = 400, errors = e.Message };
            }
            return res;

            //var _mapperCourse = _mapper.Map<Product>(product);
            //_prmanager.AddProduct(_mapperCourse);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public  JsonResult Put(int? id, [FromBody] ProductDTO productDto)
        {
            JsonResult res = new(new { });
            if (id == null)
            {
                res.Value = new { status = 403, message = "Id is required" };
                return res;
            };
            var _mapperCourse = _mapper.Map<ProductDTO, Product>(productDto);

            _prmanager.Update(id.Value, _mapperCourse);
            res.Value = new { status = 200, message = "Successfully updated" };
            return res;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public  JsonResult Delete(int? id)
        {
            JsonResult res = new(new { });
            if (!id.HasValue)
            {
                res.Value = new { status = 404 };
                return res;
            }
            try
            {
                _prmanager.Remove(id.Value);
                res.Value = new { status = 200 };
            }
            catch (Exception e)
            {
                res.Value = new { status = 403, message = e.Message };
            }
            return res;
        }
    }
}
