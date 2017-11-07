using System.Threading.Tasks;
using Abp.Application.Services;
using MyPassword.Sessions.Dto;

namespace MyPassword.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
