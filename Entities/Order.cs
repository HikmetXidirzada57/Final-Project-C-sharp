using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal TaxPrice { get; set; }
        public virtual List<OrderItem>? OrderItems { get; set; }
    }
}
