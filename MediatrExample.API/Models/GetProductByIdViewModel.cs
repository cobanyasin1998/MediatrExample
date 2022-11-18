using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrExample.API.Models
{
    public class GetProductByIdViewModel
    {
        public Guid Id { get; set; }

        public String Name { get; set; }
    }
}
