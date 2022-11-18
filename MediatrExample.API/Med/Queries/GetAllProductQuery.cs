using MediatR;
using MediatrExample.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrExample.API.Med.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductByIdViewModel>>
    {

        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductByIdViewModel>>
        {
            public Task<List<GetProductByIdViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var viewModel = new GetProductByIdViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Book"
                };
                var viewModel2 = new GetProductByIdViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Book2"
                };
                return Task.FromResult(new List<GetProductByIdViewModel>() {
                    viewModel,
                    viewModel2
                });

            }
        }
    }
}
