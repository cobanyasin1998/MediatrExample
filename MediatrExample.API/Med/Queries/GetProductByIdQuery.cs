using MediatR;
using MediatrExample.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrExample.API.Med.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdViewModel>
    {
        public Guid Id { get; set; }
    }
}
