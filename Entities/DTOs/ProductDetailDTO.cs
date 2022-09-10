using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;
namespace Entities.DTOs
{
    public class ProductDetailDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Dicount { get; set; }
        public string PhotoUrl { get; set; }
        public string SKU { get; set; }
        public bool IsSlider { get; set; }
        public bool IsRecommend { get; set; }
        public int InStock { get; set; }
        public int? CategoryId { get; set; }
        public List<int>? ProductTags { get; set; }
        //public List<TagtoProduct> TagToProducts { get; set; }
    }
}
