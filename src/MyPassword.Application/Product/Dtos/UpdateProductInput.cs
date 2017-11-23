using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace MyPassword.Application.Product.Dtos
{
    public class UpdateProductInput:EntityDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Number { get; set; }
    }
}
