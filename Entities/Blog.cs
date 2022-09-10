using Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? BlogPicture { get; set; }
        public string? Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PublishDate { get; set; }
        public bool IsDeleted { get; set; }
        public int? BlogCategoryId { get; set; }
        public virtual BlogCategory? BlogCategorys { get; set; } 
    }
}
