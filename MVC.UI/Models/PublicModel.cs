namespace MVC.UI.Models;

public class PublicModel
{
    public List<ProductItem> Products { get; set; } = new ();
    public List<SocialLink> SocialLinks { get; set; } = new ();
    public List<LinkModel> Links { get; set; } = new ();
    public BioModel Bio { get; set; } = new ();
    public StyleModel Style { get; set; } = new ();
    public List<YouTubeLink> YouTubeLinks { get; set; } = new ();
}