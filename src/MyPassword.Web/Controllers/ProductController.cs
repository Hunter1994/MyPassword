using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPassword.Application.Product;
using MyPassword.Web.Models;
using System.Threading.Tasks;

namespace MyPassword.Web.Controllers
{
    public class ProductController : MyPasswordControllerBase
    {
        private readonly IProductAppService _productAppService;
        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: Product
        public async Task<ActionResult> Index(PageRequestModelBase model)
        {
            int pageindex = 1;
            int pagesize = 10;
            var input = new Application.Product.Dtos.GetProductPageInput();
            if (model != null)
            {
                pageindex = model.PageIndex <= 0 ? pageindex : model.PageIndex;
                input.Quick = model.Quick;
            }
            input.MaxResultCount = pagesize;
            input.SkipCount = (pageindex - 1) * pagesize;
            var result = await _productAppService.GetPages(input);
            result.PageIndex = pageindex;
            return View(result);
        }

        //public async Task<ActionResult> 

    }
}