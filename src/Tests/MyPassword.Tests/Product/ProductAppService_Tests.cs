using System.Threading.Tasks;
using MyPassword.Application.Product;
using Shouldly;
using Xunit;
using System.Data.Entity;

namespace MyPassword.Tests.Product
{
    public class ProductAppService_Tests:MyPasswordTestBase
    {
        private readonly IProductAppService _productAppService;
        public ProductAppService_Tests()
        {
            _productAppService = Resolve<IProductAppService>();

        }
        [Fact]
        public async Task ShouId_Create_Product()
        {
            await _productAppService.Create(new Application.Product.Dtos.CreateProductInput()
            {
                Name = "奶粉",
                Number = 1,
                Price = 1.02m
            });

            await UsingDbContextAsync(async context =>
            {
                var p = await context.Products.FirstOrDefaultAsync(r => r.Name == "奶粉");
                p.ShouldBeNull();
                p.Name.ShouldBe("奶粉");
                p.Number.ShouldBe(1);
                p.Price.ShouldBe(1.02m);
            });
        }

    }
}
