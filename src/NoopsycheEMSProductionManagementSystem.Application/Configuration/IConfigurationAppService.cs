using System.Threading.Tasks;
using NoopsycheEMSProductionManagementSystem.Configuration.Dto;

namespace NoopsycheEMSProductionManagementSystem.Configuration
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface IConfigurationAppService
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task ChangeUiTheme(ChangeUiThemeInput input);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
