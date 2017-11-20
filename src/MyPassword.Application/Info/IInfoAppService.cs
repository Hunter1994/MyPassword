using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyPassword.Info.Dto;

namespace MyPassword.Info
{
    public interface IInfoAppService:IApplicationService
    {
        Task CreateInfo(CreateInfoDto input);

        Task<PagedResultDto<PasswordInfoDto>> GetInfoByPages(GetInfoByPageInput input);

        Task DeleteInfo(int id);

        Task<PasswordInfoDto> Get(int id);

        Task EditInfo(PasswordInfoDto input);
    }
}
