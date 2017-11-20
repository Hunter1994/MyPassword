using Abp.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPassword.Info.Dto
{
    public class EditInfoDto
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
