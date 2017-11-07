using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyPassword.Configuration.Dto;

namespace MyPassword.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyPasswordAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
