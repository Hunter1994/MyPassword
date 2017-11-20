using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Application.Services.Dto;
namespace MyPassword.Info.Dto
{
    [AutoMapFrom(typeof(PasswordInfo)),AutoMapTo(typeof(PasswordInfo))]
    public class PasswordInfoDto:EntityDto
    {
        public string Title { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Detail { get; set; }
    }
}
