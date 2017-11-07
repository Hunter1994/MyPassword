using System.Web.Mvc;

namespace MyPassword.Web.Controllers
{
    public class AboutController : MyPasswordControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}