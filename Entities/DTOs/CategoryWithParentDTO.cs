using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CategoryWithParentDTO
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public int ParentId { get; set; }
        public string ParentName { get; set; }
    }
}
