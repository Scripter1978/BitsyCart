namespace Infrastructure.Models;

public class SocialLink
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Icon { get; set; }
    public string UserName { get; set; }
    public StyleModel Style { get; set; }
}