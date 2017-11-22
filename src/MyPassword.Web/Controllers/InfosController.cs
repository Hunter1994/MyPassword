using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPassword.Authorization;
using MyPassword.Info;
using System.Threading.Tasks;
using MyPassword.Info.Dto;
using MyPassword.Web.Models.Infos;
using Abp.AutoMapper;

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
        public async Task<ActionResult> Index(GetInfoByPagesModel model)
        {
            var pageIndex = 1;
            var pageSize = 10;
            if (model!=null&& model.PageIndex > 0)
            {
                pageIndex = model.PageIndex;
            }
            var input = model.MapTo<GetInfoByPageInput>();
            input.MaxResultCount = pageSize;
            input.SkipCount = (pageIndex - 1) * pageSize;

            var ps = await _infoAppService.GetInfoByPages(input);
            ps.PageIndex = pageIndex;
            ps.PageSize = pageSize;
            return View(ps);
        }

        public async Task<ActionResult> EditInfoModal(int id)
        {
            var model = await _infoAppService.Get(id);
            return View("_EditInfoModal", model);
        }
    }
}