using System.Collections.Generic;

namespace NoopsycheEMSProductionManagementSystem.Authentication.External
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface IExternalAuthConfiguration
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        List<ExternalLoginProviderInfo> Providers { get; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
