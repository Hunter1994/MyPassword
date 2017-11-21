using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MyPassword.Product
{
    public class Product:FullAuditedEntity
    {
        public const int MaxName = 100;

        public Product() { }

        public string Name { get; set; }
        public decimal Price { get; set; }


    }
}
