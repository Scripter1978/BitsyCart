namespace Infrastructure.Models;

public class Review:Base
{
    public ulong ReviewId { get; set; }
    public Int16 RatingNumber { get; set; }
    public string Title { get; set; }
    
    public string Body { get; set; }
    public string Image { get; set; }
    public string ReviewersName { get; set; }
    public string ReviewersEmail { get; set; }
    
    public Product Product { get; set; }
    
}