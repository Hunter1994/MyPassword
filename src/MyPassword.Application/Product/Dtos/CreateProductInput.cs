using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Dependency;

namespace MyPassword.Application.Product.Dtos
{
    [AutoMapTo(typeof(MyPassword.Core.Product.Product))]
    public class CreateProductInput
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Number { get; set; }
    }
}
