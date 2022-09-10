using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrderItem:IEntity
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ProductId { get; set; }
        public bool IsRefunded { get; set; }
    }
}
