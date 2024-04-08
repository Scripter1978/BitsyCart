namespace Infrastructure.Models;

public class ProductListingHistory:Base
{
    public ulong ProductListingHistoryId { get; set; }
    public DateTimeOffset DateChange { get; set; }
    public Product Product { get; set; }
}