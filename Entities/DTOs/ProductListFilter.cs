using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Entities.DTOs
{
    public class ProductListFilter
    {
        public decimal MaxPrice { get; set; }
        public List<ProductListDTO>  Products { get; set; }
        //public int CurrentPage { get; set; }
        //public int? PageNo { get; set; }
        //public int MaxPage { get; set; }
        //public Pager Pager { get; set; }

    }
}
