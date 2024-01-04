using CQRSMediatRExample.API.Models;
using MediatR;

namespace CQRSMediatRExample.API.Command.AddProduct
{
    public class AddProductWithResultCommand : IRequest<CustomResult<string>>
    {
        public string Tittle { get; set; }
        public string Description { get; set; }

        public Product ToEntity()
            => new(Tittle, Description);
    }
}
