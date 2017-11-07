using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyPassword.MultiTenancy.Dto;

namespace MyPassword.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
