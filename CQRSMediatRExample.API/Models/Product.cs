namespace CQRSMediatRExample.API.Models
{
    public class Product(string? Title, string? Description)
    {
        public Guid Id { get; set; } = new Guid();
        public string Description { get; set; } = Title;
        public string Title { get; set; } = Description;
    }
}
