using CQRSMediatRExample.API.Models;
using CQRSMediatRExample.API.Persistence;
using MediatR;

namespace CQRSMediatRExample.API.Command.ListProduct
{
    public class ListProductCommandHandler(CqrsMediatRBdContext context) : IRequestHandler<ListProductCommand, CustomResult<IList<Product>>>
    {
        private readonly CqrsMediatRBdContext _context = context;

        public Task<CustomResult<IList<Product>>> Handle(ListProductCommand request, CancellationToken cancellationToken)
        {
            var products = _context.Products;

            if(products.Count == 0)
            {
                return Task.FromResult(new CustomResult<IList<Product>>("Lista vazia", false, products));
            }

            var result = new CustomResult<IList<Product>>("Sucesso", true, products);

            return Task.FromResult(result);
        }
    }
}
