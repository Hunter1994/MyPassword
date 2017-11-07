using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Abp.Auditing;

namespace MyPassword.Info.Dto
{
    [AutoMapFrom(typeof(PasswordInfo))]
    public class CreateInfoDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [DisableAuditing]
        public string UserName { get; set; }
        [Required]
        [DisableAuditing]
        public string Password { get; set; }
        [Required]
        [DisableAuditing]
        public string Detail { get; set; }

    }
}
