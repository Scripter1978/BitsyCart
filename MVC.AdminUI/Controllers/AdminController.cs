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
            return View();
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
        public ActionResult AddLink(LinkView linkView)
        {
            const int length = 6;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            linkView.Id = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return View(linkView);
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
        public ActionResult Sort(List<LinkView> linkViews)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return Ok();
            }
        }

    }
}
