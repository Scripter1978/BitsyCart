namespace Infrastructure.Models;

public class Product :Base
{
    public ulong ProductId { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string SubTitle { get; set; }
    public string ShortDescription { get; set; }
    public string PreviewImage { get; set; }
    public decimal Price { get; set; } 
    public string Currency { get; set; }
    public ICollection<ProductListingHistory> ProductListingHistorys { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public User User { get; set; }
    
}