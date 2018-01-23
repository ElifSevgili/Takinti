using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Takinti.Models;

namespace Takinti.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string slug="")
        {
            return View();
        }
        public ActionResult Details(string slug = "")
        {   
            using(var db=new ApplicationDbContext())
            {
                var product = db.Products.FirstOrDefault(p => p.Slug.ToLower() == slug.ToLower() && p.IsPublished == true);
                return View(product);
            }
            
        }
    }
}