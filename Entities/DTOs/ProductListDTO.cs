using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Entities.DTOs
{
    public class ProductListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Dicount { get; set; }
        public string PhotoUrl { get; set; }
        public decimal? Rating { get; set; }
        public string? SKU { get; set; }
        public int InStock { get; set; }
        public string CategoryName { get; set; } = null!;
        public int CategoryId { get; set; }
        public List<SpecificationDTO>? ProductSpesifications { get; set; }
        public virtual List<TagtoProduct> ProductTags { get; set; }


    }
}
