using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MyPassword.Info
{
    public class PasswordInfo : FullAuditedEntity
    {
        public string Title { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Detail { get; set; }
    }
}
