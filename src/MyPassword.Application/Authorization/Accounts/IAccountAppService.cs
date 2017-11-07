using System.Threading.Tasks;
using Abp.Application.Services;
using MyPassword.Authorization.Accounts.Dto;

namespace MyPassword.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
