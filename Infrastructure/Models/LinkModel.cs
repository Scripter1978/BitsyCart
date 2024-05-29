namespace Infrastructure.Models;

public class LinkModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public StyleModel Style { get; set; } = new ();
}