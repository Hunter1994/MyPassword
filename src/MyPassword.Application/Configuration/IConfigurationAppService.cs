using System.Threading.Tasks;
using Abp.Application.Services;
using MyPassword.Configuration.Dto;

namespace MyPassword.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}