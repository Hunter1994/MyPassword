using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPassword.Authorization;
using MyPassword.Info;
using System.Threading.Tasks;

namespace MyPassword.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Info)]
    public class InfosController : Controller
    {
        private readonly IInfoAppService _infoAppService;
        public InfosController(IInfoAppService infoAppService)
        {
            this._infoAppService = infoAppService;
        }
        // GET: Infos
        public async Task<ActionResult> Index()
        {
           var ps= await _infoAppService.GetInfoByPages(new Info.Dto.GetInfoByPageInput() { MaxResultCount = 10, SkipCount = 0 });
            return View(ps);
        }
    }
}