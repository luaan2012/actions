using CQRSMediatRExample.API.Models;
using MediatR;

namespace CQRSMediatRExample.API.Command.ListProduct
{
    public class ListProductCommand() : IRequest<CustomResult<IList<Product>>>
    {
    }
}
