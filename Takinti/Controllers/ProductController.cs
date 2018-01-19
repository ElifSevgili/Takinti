using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Takinti.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(string slug="")
        {
            return View();
        }
    }
}