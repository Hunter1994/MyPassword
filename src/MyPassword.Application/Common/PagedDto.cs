using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPassword
{
    public class PagedResultExtDto<T>: PagedResultDto<T>
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
