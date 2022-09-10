using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CategoryListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? IconUrl { get; set; }
        public int? PrentcategoryId { get; set; }
    }
}
