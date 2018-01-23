using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Takinti.Models;

namespace Takinti.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {  
            using(var db=new ApplicationDbContext())
            {
                var categories = db.Categories.Include("ChildCategories").Include("ChildCategories.ChildCategories").Include("Products").Where(w => w.ParentCategoryId == null).ToList();
                ViewBag.Categories = categories;
            }

            return View();
        }

       

        public ActionResult Contact()
        {
          

            return View();
        }
    }
}