using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using MyPassword.Info;
using Abp.Application.Services.Dto;

namespace MyPassword.Info.Dto
{
    [AutoMapFrom(typeof(PasswordInfo))]
    public class GetInfoByPageInput: PagedAndSortedResultRequestDto
    {
        public string Quick { get; set; }
        public string Title { get; set; }

        public string UserName { get; set; }
    }
}
