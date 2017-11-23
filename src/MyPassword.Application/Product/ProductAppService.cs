using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPassword.Application.Product.Dtos;
using Abp.AutoMapper;
using MyPassword.Core.Product;
using Abp.Domain.Repositories;

namespace MyPassword.Application.Product
{
    public class ProductAppService :MyPasswordAppServiceBase, IProductAppService
    {
        private readonly IRepository<MyPassword.Core.Product.Product> _productRepository;
        private readonly IProductPolicy _policy;
        public ProductAppService(IRepository<MyPassword.Core.Product.Product> productRepository, IProductPolicy policy)
        {
            _productRepository = productRepository;
            _policy = policy;
        }

        public async Task Create(CreateProductInput input)
        {
            MyPassword.Core.Product.Product product = new Core.Product.Product();
            product.UpdateName(input.Name);
            product.UpdateNumber(input.Number, _policy);
            product.UpdatePrice(input.Price, _policy);
            await _productRepository.InsertAsync(product);
        }

        public async Task<ProductDto> Get(int id)
        {
               
            return (await _productRepository.GetAsync(id)).MapTo<ProductDto>();
        }

        public Task<PagedResultExtDto<ProductDto>> GetPages(GetProductPageInput input)
        {
            throw new NotImplementedException();
        }

        public async Task Update(UpdateProductInput input)
        {
            var product = await _productRepository.GetAsync(input.Id);
            product.UpdateName(input.Name);
            product.UpdatePrice(input.Price,_policy);
            product.UpdateNumber(input.Number, _policy);
        }
    }
}
