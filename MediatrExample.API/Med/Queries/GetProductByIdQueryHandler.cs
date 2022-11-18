using MediatR;
using MediatrExample.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrExample.API.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdViewModel>
    {
        public Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            //GetProductFromRepository
            var viewModel = new GetProductByIdViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            };

            return Task.FromResult(viewModel);


        }
    }
}
