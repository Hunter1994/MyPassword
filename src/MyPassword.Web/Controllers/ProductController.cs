using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPassword.Web.Controllers
{
    public class ProductController : MyPasswordControllerBase
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
    }
}