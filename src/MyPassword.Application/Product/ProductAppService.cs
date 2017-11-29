using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPassword.Application.Product.Dtos;
using Abp.AutoMapper;
using MyPassword.Core.Product;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.Application.Features;
using Abp.MultiTenancy;
using Abp.Zero;
using Abp.Application.Editions;

namespace MyPassword.Application.Product
{
    public class ProductAppService :MyPasswordAppServiceBase, IProductAppService
    {
        private readonly IRepository<TenantFeatureSetting, long> _tenantFeatureRepository;
        private readonly IRepository<MyPassword.Core.Product.Product> _productRepository;
        private readonly IProductPolicy _policy;
        private readonly IAbpZeroFeatureValueStore _abpZeroFeatureValueStore;
        private readonly AbpEditionManager _abpEditionManager;
        public ProductAppService(IRepository<MyPassword.Core.Product.Product> productRepository, 
            IProductPolicy policy, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository,
            IAbpZeroFeatureValueStore abpZeroFeatureValueStore,
            AbpEditionManager abpEditionManager)
        {
            _abpEditionManager = abpEditionManager;
            _tenantFeatureRepository = tenantFeatureRepository;
            _productRepository = productRepository;
            _policy = policy;
            _abpZeroFeatureValueStore = abpZeroFeatureValueStore;
    }

        public async Task Create(CreateProductInput input)
        {
            //TenantManager.SetFeatureValue(1, "Product", "false");

            //添加版本
            //await _abpEditionManager.CreateAsync(new Edition("Enterprise"));
            //FeatureChecker.CheckEnabled("Product");
            // await _abpZeroFeatureValueStore.SetEditionFeatureValueAsync(1, "Product", "false");
            //var tenant = AbpSession.TenantId;
            //MyPassword.Core.Product.Product product = new Core.Product.Product();
            //product.UpdateName(input.Name);
            //product.UpdateNumber(input.Number, _policy);
            //product.UpdatePrice(input.Price, _policy);
            //await _productRepository.InsertAsync(product);
        }

        public async Task<ProductDto> Get(int id)
        {
            return (await _productRepository.GetAsync(id)).MapTo<ProductDto>();
        }

        public async Task<PagedResultExtDto<ProductDto>> GetPages(GetProductPageInput input)
        {
            var query = _productRepository.GetAll().WhereIf(!input.Quick.IsNullOrEmpty(), r => r.Name.Contains(input.Quick));
            query = query.OrderBy(r => r.CreationTime);
            var count = query.Count();
            var products = query.PageBy(input).ToList();
            return await Task.FromResult(new PagedResultExtDto<ProductDto>()
            {
                Items = products.MapTo<List<ProductDto>>(),
                PageSize = input.MaxResultCount,
                TotalCount = count
            });
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
