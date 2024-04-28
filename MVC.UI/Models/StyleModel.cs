namespace MVC.UI.Models;

public class StyleModel
{
    #region SocialStyles
    public string SocialFontColor { get; set; }
    #endregion

    #region LinkStyles
    public string LinkFontColor { get; set; }   
    public string LinkBorderColor { get; set; }
    public string LinkBorderWidth { get; set; }
    #endregion

    #region BioStyles
    public string BioFontColor { get; set; }
    public string BioFontStyle { get; set; }
    public string BioFontWeight { get; set; }
    public string BioFontSize { get; set; }
    public string BioFontType { get; set; }
    #endregion
    public string BackgroundColor { get; set; }
    public string FontFamily { get; set; }
    public string FontSize { get; set; }
    public string FontWeight { get; set; }
}