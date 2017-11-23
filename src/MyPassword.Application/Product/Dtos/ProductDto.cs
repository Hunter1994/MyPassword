using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace MyPassword.Application.Product.Dtos
{
    [AutoMapFrom(typeof(MyPassword.Core.Product.Product))]
    public class ProductDto:EntityDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Number { get; set; }
    }
}
