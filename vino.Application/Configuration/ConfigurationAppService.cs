using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using vino.Configuration.Dto;

namespace vino.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : vinoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
