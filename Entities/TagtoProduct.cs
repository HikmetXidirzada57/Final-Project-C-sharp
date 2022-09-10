using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TagtoProduct:IEntity
    {
        public int Id { get; set; }
        public  int ProductId { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
