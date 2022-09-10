using Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Dicount { get; set; }
        public string PhotoUrl { get; set; } = null!;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? PublishDate { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public decimal?  Rating { get; set; }
        public string? SKU { get; set; }
        public int InStock { get; set; }
        public bool IsSlider { get; set; }
        public bool  IsRecommend { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Category? Category { get; set; }
        public int CategoryId { get; set; }
        public virtual List<ProductSpesification>? ProductSpesifications { get; set; }
        public virtual List<TagtoProduct> ProductTags { get; set; }

    }
}
