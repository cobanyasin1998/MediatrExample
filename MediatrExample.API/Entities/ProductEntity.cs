using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrExample.API.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public Int32 Quantity { get; set; }
        public Decimal Amount { get; set; }
    }
}
