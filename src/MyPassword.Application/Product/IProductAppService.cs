using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPassword.Application.Product.Dtos;
using Abp.Application.Services;

namespace MyPassword.Application.Product
{
    public interface IProductAppService: IApplicationService
    {
        Task Create(CreateProductInput input);
        Task Update(UpdateProductInput input);
        Task<PagedResultExtDto<ProductDto>> GetPages(GetProductPageInput input);
        Task<ProductDto> Get(int id);
    }
}
