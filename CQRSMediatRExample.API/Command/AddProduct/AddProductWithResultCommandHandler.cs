using CQRSMediatRExample.API.Models;
using CQRSMediatRExample.API.Persistence;
using MediatR;

namespace CQRSMediatRExample.API.Command.AddProduct
{
    public class AddProductWithResultCommandHandler(CqrsMediatRBdContext context) : IRequestHandler<AddProductWithResultCommand, CustomResult<string>>
    {
        private readonly CqrsMediatRBdContext _context = context;

        public Task<CustomResult<string>> Handle(AddProductWithResultCommand request, CancellationToken cancellationToken)
        {
            var product = request.ToEntity();

            _context.Products.Add(product);

            var result = new CustomResult<string>(data: product.Title);

            return Task.FromResult(result);
        }
    }
}
