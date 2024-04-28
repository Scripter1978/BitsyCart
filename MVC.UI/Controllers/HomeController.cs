using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.UI.Models;

namespace MVC.UI.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [Route("Privacy", Name = "Privacy", Order = 0)]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


    [Route("{id?}", Name = null, Order = 15)] 
    public IActionResult Public(string? id)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            return NotFound();
        }
        return View(new PublicModel()
        {
            SocialLinks = new()
            {
              new ()
              {
                 Name = "Facebook",
                 Url = "https://www.facebook.com",
                 Icon = "<svg fill=\"currentColor\" width=\"24\" height=\"24\" xmlns=\"http://www.w3.org/2000/svg\" role=\"img\" viewBox=\"0 0 24 24\"><title>Facebook</title><path d=\"M9.101 23.691v-7.98H6.627v-3.667h2.474v-1.58c0-4.085 1.848-5.978 5.858-5.978.401 0 .955.042 1.468.103a8.68 8.68 0 0 1 1.141.195v3.325a8.623 8.623 0 0 0-.653-.036 26.805 26.805 0 0 0-.733-.009c-.707 0-1.259.096-1.675.309a1.686 1.686 0 0 0-.679.622c-.258.42-.374.995-.374 1.752v1.297h3.919l-.386 2.103-.287 1.564h-3.246v8.245C19.396 23.238 24 18.179 24 12.044c0-6.627-5.373-12-12-12s-12 5.373-12 12c0 5.628 3.874 10.35 9.101 11.647Z\"/></svg>"
              },
              new ()
              {
                  Name = "Twitter",
                  Url = "https://x.com",
                  Icon = "<svg fill=\"currentColor\" width=\"24\" height=\"24\"  xmlns=\"http://www.w3.org/2000/svg\" role=\"img\" viewBox=\"0 0 24 24\"><title>X</title><path d=\"M18.901 1.153h3.68l-8.04 9.19L24 22.846h-7.406l-5.8-7.584-6.638 7.584H.474l8.6-9.83L0 1.154h7.594l5.243 6.932ZM17.61 20.644h2.039L6.486 3.24H4.298Z\"/></svg>"
              },
              new ()
              {
                  Name = "Twitch",
                  Url = "https://www.twitch.com",
                  Icon = "<svg fill=\"currentColor\" width=\"24\" height=\"24\" role=\"img\" viewBox=\"0 0 24 24\" xmlns=\"http://www.w3.org/2000/svg\"><title>Twitch</title><path d=\"M11.571 4.714h1.715v5.143H11.57zm4.715 0H18v5.143h-1.714zM6 0L1.714 4.286v15.428h5.143V24l4.286-4.286h3.428L22.286 12V0zm14.571 11.143l-3.428 3.428h-3.429l-3 3v-3H6.857V1.714h13.714Z\"/></svg>"
              },
              new ()
              {
                  Name = "LinkedIn",
                  Url = "https://www.linkedin.com",
                  Icon = "<svg fill=\"currentColor\" width=\"24\" height=\"24\" role=\"img\" viewBox=\"0 0 24 24\" xmlns=\"http://www.w3.org/2000/svg\"><title>LinkedIn</title><path d=\"M20.447 20.452h-3.554v-5.569c0-1.328-.027-3.037-1.852-3.037-1.853 0-2.136 1.445-2.136 2.939v5.667H9.351V9h3.414v1.561h.046c.477-.9 1.637-1.85 3.37-1.85 3.601 0 4.267 2.37 4.267 5.455v6.286zM5.337 7.433c-1.144 0-2.063-.926-2.063-2.065 0-1.138.92-2.063 2.063-2.063 1.14 0 2.064.925 2.064 2.063 0 1.139-.925 2.065-2.064 2.065zm1.782 13.019H3.555V9h3.564v11.452zM22.225 0H1.771C.792 0 0 .774 0 1.729v20.542C0 23.227.792 24 1.771 24h20.451C23.2 24 24 23.227 24 22.271V1.729C24 .774 23.2 0 22.222 0h.003z\"/></svg>"
              }  
            },
            Products = new()
            {
                new (){ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
                new (){ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
                new (){ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
                new (){ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
                new (){ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
                new (){ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
                new (){ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
                new (){ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
                new (){ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
                new (){ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
                new (){ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
                new (){ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
                new (){ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"},
                new (){ PreviewImage = "TEST IMAGE", SubTitle = "Sub Title", Title = "Title", Description = "Description", Uid = "UID", Price = "$99.95"},
                new (){ PreviewImage = "TEST IMAGE2", SubTitle = "Sub Title2", Title = "Title2", Description = "Description2", Uid = "UID2", Price = "$45.10"},
                new (){ PreviewImage = "TEST IMAGE3", SubTitle = "Sub Title3", Title = "Title3", Description = "Description3", Uid = "UID3", Price = "$12.32"}
            },
            Links = new()
            {
                new ()
                {
                    Name = "Amazon",
                    Url = "https://www.amazon.com"
                },
                new ()
                {
                    Name = "Amazon Shirt",
                    Url = "https://www.amazon.com"
                },
                new ()
                {
                    Name = "Amazon Pants",
                    Url = "https://www.amazon.com"
                }
            },
            Bio = new ()
            {
                Body = "Some Information about me!!!!!!!!"
            },
            Style = new ()
            {
                //BackgroundColor = "#000000",
                SocialFontColor = "#61d804",
                BioFontColor = "#61d804",
                BioFontStyle = "italic",
                BioFontWeight = "bold",
                BioFontSize = "20px",
                BioFontType = "Arial",
                LinkBorderColor = "#fff",
                LinkFontColor = "#61d804"
            },
            YouTubeLinks = new ()
            {
                new ()
                {
                    Link = "https://www.youtube.com/embed/Ir7J0eEuWgk?feature=oembed&enablejsapi=1",
                    Title = "Some Video I Found",
                    Description = "This is a video I found on the internet",
                    Height = "155",
                    Width = "300"
                },
                new ()
                {
                    Link = "http://www.youtube.com/embed/UkWd0azv3fQ",
                    Title = "Some Video I Found",
                    Description = "This is a video I found on the internet",
                    Height = "155",
                    Width = "300"
                },new ()
                {
                    Link = "http://www.youtube.com/embed/UkWd0azv3fQ",
                    Title = "Some Video I Found",
                    Description = "This is a video I found on the internet",
                    Height = "155",
                    Width = "300"
                },new ()
                {
                    Link = "http://www.youtube.com/embed/UkWd0azv3fQ",
                    Title = "Some Video I Found",
                    Description = "This is a video I found on the internet",
                    Height = "155",
                    Width = "300"
                }
            }
        }  );
    } 
        
        
}