using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using GoodHost.Configuration.Dto;

namespace GoodHost.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : GoodHostAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
