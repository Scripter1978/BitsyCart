namespace Infrastructure.Models;

public class Base
{
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset Updated { get; set; }
    public int Status { get; set; }
}