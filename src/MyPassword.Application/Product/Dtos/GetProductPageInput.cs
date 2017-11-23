using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
namespace MyPassword.Application.Product.Dtos
{
    public class GetProductPageInput:PagedAndSortedResultRequestDto
    {
        public string Quick { get; set; }
    }
}
