using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPassword.Authorization;

namespace MyPassword.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Info)]
    public class InfosController : Controller
    {
        // GET: Infos
        public ActionResult Index()
        {
            return View();
        }
    }
}