using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyPassword.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyPasswordControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}