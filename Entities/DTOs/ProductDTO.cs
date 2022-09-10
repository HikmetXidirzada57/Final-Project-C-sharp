using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Dicount { get; set; }
        public string PhotoUrl { get; set; } = null!;
        public DateTime? PublishDate { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public decimal? Rating { get; set; }
        public string? SKU { get; set; }
        public int InStock { get; set; }
        public bool IsSlider { get; set; }
        public bool IsRecommend { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public List<TagDTO> ProductTagsList { get; set; }
        public List<SpecificationDTO>? SpecificationList { get; set; }

    }
}
