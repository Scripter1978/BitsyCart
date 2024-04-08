namespace Infrastructure.Models;

public class User:Base
{
    public ulong UserId { get; set; }
    public string UserIdentifier { get; set; } 
    public ICollection<Product> Products { get; set; }
}