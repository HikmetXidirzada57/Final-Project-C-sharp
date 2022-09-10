using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class BlogDTO
    {
        public string? Name { get; set; }
        public string? BlogPicture { get; set; }
        public string? Description { get; set; }
        public int? BlogCategoryId { get; set; }

    }
}
