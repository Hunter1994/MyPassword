using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyPassword.Info.Dto;
using Abp.Domain.Repositories;
using MyPassword.Info;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using Abp.Extensions;

namespace MyPassword.Info
{
    public class InfoAppService : ApplicationService, IInfoAppService
    {
        private readonly IRepository<PasswordInfo> _passwordInfoRepository;

        public InfoAppService(IRepository<PasswordInfo> passwordInfoRepository)
        {
            _passwordInfoRepository = passwordInfoRepository;
        }

        public async Task CreateInfo(CreateInfoDto input)
        {
            var pi = input.MapTo<PasswordInfo>();
            await _passwordInfoRepository.InsertAsync(pi);
        }

        public async Task<PagedResultDto<PasswordInfo>> GetInfoByPages(GetInfoByPageInput input)
        {
            var query = _passwordInfoRepository.GetAll()
                .WhereIf(input.Title.IsNullOrEmpty(), t => t.Title.Contains(input.Title))
                .WhereIf(input.UserName.IsNullOrEmpty(), t => t.UserName.Contains(input.UserName));

            query = query.OrderBy(r => r.CreationTime);

            var data = query.PageBy(input).ToList();
            var total = query.Count();

            return await Task.FromResult(new PagedResultDto<PasswordInfo>()
            {
                TotalCount = total,
                Items = data
            });
        }
    }
}
