using CQRSMediatRExample.API.Models;

namespace CQRSMediatRExample.API.Persistence
{
    public class CqrsMediatRBdContext
    {
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
