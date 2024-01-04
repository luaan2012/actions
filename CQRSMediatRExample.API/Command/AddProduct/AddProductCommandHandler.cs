using CQRSMediatRExample.API.Persistence;
using MediatR;

namespace CQRSMediatRExample.API.Command.AddProduct
{
    public class AddProductCommandHandler(CqrsMediatRBdContext context) : IRequestHandler<AddProductCommand>
    {
        private readonly CqrsMediatRBdContext _context = context;

        public Task Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = request.ToEntity();

            _context.Products.Add(product);

            return Task.CompletedTask;
        }
    }
}
