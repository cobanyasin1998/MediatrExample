using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrExample.API.Med.Commands
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                //repo aracılıgıyla veri tabanına gönderilir


                return Task.FromResult(Guid.NewGuid());
            }
        }
    }
}
