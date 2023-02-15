using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NoopsycheEMSProductionManagementSystem.Configuration.Dto;

namespace NoopsycheEMSProductionManagementSystem.Configuration
{
    [AbpAuthorize]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ConfigurationAppService : NoopsycheEMSProductionManagementSystemAppServiceBase, IConfigurationAppService
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
