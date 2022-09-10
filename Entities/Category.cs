using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? IconUrl { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? ModeifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int? ParentCategoryId { get; set; }
        public virtual Category? ParentCategory { get; set; }
    }   
}
