using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.AdminUI.Models;

namespace MVC.AdminUI.Controllers
{
    public class AdminController : Controller
    {
        private static Random random = new Random();
        // GET: Admin
        public ActionResult Index()
        {
            var publicModel = new PublicModel()
            {  
                Image = Url.Content("~/img/blank.png"),
                SocialLinks = new List<SocialLink>()
                {
                    new SocialLink()
                    {
                        Id = "1",
                        Name = "Facebook",
                        Url = "https://www.facebook.com",
                        Icon = "<svg viewBox=\"0 0 36 36\" class=\"\" style=\"\" fill=\"white\" height=\"24\" width=\"24\"><path d=\"M20.181 35.87C29.094 34.791 36 27.202 36 18c0-9.941-8.059-18-18-18S0 8.059 0 18c0 8.442 5.811 15.526 13.652 17.471L14 34h5.5l.681 1.87Z\"></path><path style=\"fill: black;\" d=\"M13.651 35.471v-11.97H9.936V18h3.715v-2.37c0-6.127 2.772-8.964 8.784-8.964 1.138 0 3.103.223 3.91.446v4.983c-.425-.043-1.167-.065-2.081-.065-2.952 0-4.09 1.116-4.09 4.025V18h5.883l-1.008 5.5h-4.867v12.37a18.183 18.183 0 0 1-6.53-.399Z\"></path></svg>",
                        UserName = "HalfAcreLife",
                        Style = new StyleModel()
                        {
                            BackgroundColor = "#000000",
                            SocialFontColor = "#61d804",
                            BioFontColor = "#61d804",
                            BioFontStyle = "italic",
                            BioFontWeight = "bold",
                            BioFontSize = "20px",
                            BioFontType = "Arial",
                            LinkBorderColor = "#fff",
                            LinkFontColor = "#61d804"
                        }
                    }  
                }
            };
            return View(publicModel);
        }

        [HttpGet]
        [Route("Admin/Bio", Name = "Bio")]
        public ActionResult Bio()
        {
            return View(new BioView());
        }
        
        [HttpPut]
        [Route("Admin/Bio", Name = "Bio")]
        public ActionResult Bio(BioView bioView)
        {
            
            return View(bioView);
        } 

        [HttpGet]
        [Route("Admin/Links", Name = "Links")]
        public ActionResult Links()
        {
            return View(new List<LinkView>());
        }
        
        [HttpPost]
        [Route("Admin/AddLink", Name = "AddLink")]
        public ActionResult AddLink(LinkModel linkView)
        {
            const int length = 6;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            linkView.Id = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return View(linkView);
        }
        [HttpPatch]
        [Route("Admin/DeleteLink", Name = "DeleteLink")]
        public ActionResult DeleteLink(LinkModel linkView)
        {
            return NoContent(); 
        }
        [HttpPost]
        [Route("Admin/AddAvatar", Name = "AddAvatar")]
        public async Task<ActionResult> AddAvatar(IFormFile avatar)
        { 
            var filePath = Path.GetTempFileName();

            await using (var stream = System.IO.File.Create(filePath))
            {
                await avatar.CopyToAsync(stream);
            }
            return View();
        }
        
        
        [HttpGet]
        [Route("Admin/Products", Name = "Products")]
        public ActionResult Products()
        {
            return View(new List<LinkView>());
        }
        
        [HttpPost]
        [Route("Admin/AddProduct", Name = "AddProduct")]
        public ActionResult AddProduct(ProductItem productItem)
        {
            const int length = 6;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            productItem.Uid = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return View(productItem);
        }
        
        [HttpGet]
        [Route("Admin/SocialModal/{social}", Name = "SocialModal")]
        public ActionResult SocialModal(string social)
        {
            return social switch
            {
                "facebook" => View(new SocialModal()
                {
                    Name = "Facebook",
                    Icon =
                        "<svg viewBox=\"0 0 36 36\" class=\"\" style=\"\" fill=\"white\" height=\"24\" width=\"24\"><path d=\"M20.181 35.87C29.094 34.791 36 27.202 36 18c0-9.941-8.059-18-18-18S0 8.059 0 18c0 8.442 5.811 15.526 13.652 17.471L14 34h5.5l.681 1.87Z\"></path><path style=\"fill: black;\" d=\"M13.651 35.471v-11.97H9.936V18h3.715v-2.37c0-6.127 2.772-8.964 8.784-8.964 1.138 0 3.103.223 3.91.446v4.983c-.425-.043-1.167-.065-2.081-.065-2.952 0-4.09 1.116-4.09 4.025V18h5.883l-1.008 5.5h-4.867v12.37a18.183 18.183 0 0 1-6.53-.399Z\"></path></svg>",
                    Url = "https://www.facebook.com"
                }),
                "twitter" => View(new SocialModal()
                {
                    Name = "Twitter",
                    Icon =
                        "<svg viewBox=\"0 0 24 24\" aria-hidden=\"true\" fill=\"white\" class=\"\" height=\"24\" width=\"24\"><g><path d=\"M18.244 2.25h3.308l-7.227 8.26 8.502 11.24H16.17l-5.214-6.817L4.99 21.75H1.68l7.73-8.835L1.254 2.25H8.08l4.713 6.231zm-1.161 17.52h1.833L7.084 4.126H5.117z\"></path></g></svg>",
                    Url = "https://www.twitter.com"
                }),
                "linkedin" => View(new SocialModal()
                {
                    Name = "LinkedIn",
                    Icon =
                        "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox=\"0 0 24 24\" data-supported-dps=\"24x24\" fill=\"currentColor\" class=\"mercado-match\" width=\"24\" height=\"24\" focusable=\"false\"><path d=\"M20.5 2h-17A1.5 1.5 0 002 3.5v17A1.5 1.5 0 003.5 22h17a1.5 1.5 0 001.5-1.5v-17A1.5 1.5 0 0020.5 2zM8 19H5v-9h3zM6.5 8.25A1.75 1.75 0 118.3 6.5a1.78 1.78 0 01-1.8 1.75zM19 19h-3v-4.74c0-1.42-.6-1.93-1.38-1.93A1.74 1.74 0 0013 14.19a.66.66 0 000 .14V19h-3v-9h2.9v1.3a3.11 3.11 0 012.7-1.4c1.55 0 3.36.86 3.36 3.66z\"></path></svg>",
                    Url = "https://www.linkedin.com"
                }),
                _ => BadRequest()
            };
        }
        [HttpPost]
        [Route("Admin/AddSocialLink", Name = "AddSocialLink")]
        public ActionResult AddSocialLink([FromForm] SocialModal socialView)
        {
            var url = socialView.Name.ToLower() switch
            {
                "facebook" => $"https://www.facebook.com/{socialView.UserName}",
                "twitter" => $"https://www.twitter.com/{socialView.UserName}",
                "linkedin" => $"https://www.linkedin.com/in/{socialView.UserName}",
                _ => ""
            };
            var social = new SocialLink
            {
                Icon = socialView.Icon,
                Name = socialView.Name,
                Url = url,
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
                }
            };
            const int length = 6;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            social.Id = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            
            return View(social);
        }
        [HttpPost]
        [Route("Admin/SocialLink", Name = "SocialLink")]
        public ActionResult SocialLink(SocialModal socialView)
        {
            var url = socialView.Name.ToLower() switch
            {
                "facebook" => $"https://www.facebook.com/{socialView.UserName}",
                "twitter" => $"https://www.twitter.com/{socialView.UserName}",
                "linkedin" => $"https://www.linkedin.com/in/{socialView.UserName}",
                _ => ""
            };
            var social = new SocialLink()
            {
                Icon = socialView.Icon,
                Name = socialView.Name,
                Url = url
            };
            const int length = 6;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            social.Id = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            
            return View(social);
        }
        
        [HttpGet]
        [Route("Admin/Socials", Name = "Socials")]
        public ActionResult Socials()
        {
            return View(new List<SocialLink>());
        }
        
        [HttpPost]
        [Route("Admin/Social", Name = "Social")]
        public ActionResult Social(SocialLink socialView)
        {
            const int length = 6;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            socialView.Id = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return View(socialView);
        }
        
        
        [HttpPost]
        [Route("Admin/AddBio", Name = "AddBio")]
        public ActionResult AddBio(BioModel bioModel)
        {
            return View(bioModel);
        }

        [HttpGet]
        [Route("Admin/PublicEdit", Name = "PublicEdit")]
        public ActionResult PublicEdit()
        {
            var publicModel = new PublicModel()
            {  
                Image = Url.Content("~/img/blank.png"),
                SocialLinks = new List<SocialLink>()
                {
                    new SocialLink()
                    {
                        Id = "1",
                        Name = "Facebook",
                        Url = "https://www.facebook.com",
                        Icon = "<svg viewBox=\"0 0 36 36\" class=\"\" style=\"\" fill=\"white\" height=\"24\" width=\"24\"><path d=\"M20.181 35.87C29.094 34.791 36 27.202 36 18c0-9.941-8.059-18-18-18S0 8.059 0 18c0 8.442 5.811 15.526 13.652 17.471L14 34h5.5l.681 1.87Z\"></path><path style=\"fill: black;\" d=\"M13.651 35.471v-11.97H9.936V18h3.715v-2.37c0-6.127 2.772-8.964 8.784-8.964 1.138 0 3.103.223 3.91.446v4.983c-.425-.043-1.167-.065-2.081-.065-2.952 0-4.09 1.116-4.09 4.025V18h5.883l-1.008 5.5h-4.867v12.37a18.183 18.183 0 0 1-6.53-.399Z\"></path></svg>",
                        UserName = "HalfAcreLife",
                        Style = new StyleModel()
                        {
                            BackgroundColor = "#000000",
                            SocialFontColor = "#61d804",
                            BioFontColor = "#61d804",
                            BioFontStyle = "italic",
                            BioFontWeight = "bold",
                            BioFontSize = "20px",
                            BioFontType = "Arial",
                            LinkBorderColor = "#fff",
                            LinkFontColor = "#61d804"
                        }
                    }  
                }
            };
            return View(publicModel);
        } 
        
        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpDelete]
        // [ValidateAntiForgeryToken]
        [Route("Admin/Delete", Name = "Delete")]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        
        
        
        // POST: Admin/Edit/5
        [HttpPost]
        // [ValidateAntiForgeryToken]
        [Route("Admin/Sort", Name = "Sort")]
        public ActionResult Sort(IFormCollection section)
        {
            try
            {
                var sortedList = section["sortedIDs"].ToString().Split(',').ToList();
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }

    }
}
