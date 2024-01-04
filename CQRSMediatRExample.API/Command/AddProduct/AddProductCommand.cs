using CQRSMediatRExample.API.Models;
using MediatR;

namespace CQRSMediatRExample.API.Command.AddProduct
{
    public class AddProductCommand : IRequest
    {
        public string Tittle { get; set; }
        public string Description { get; set; }

        public Product ToEntity()
            => new(Tittle, Description);
    }
}
