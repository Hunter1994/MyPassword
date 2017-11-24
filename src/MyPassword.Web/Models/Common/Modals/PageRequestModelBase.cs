using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPassword.Web.Models
{
    public class PageRequestModelBase
    {
        public int PageIndex { get; set; }
        public string Quick { get; set; }
    }
}