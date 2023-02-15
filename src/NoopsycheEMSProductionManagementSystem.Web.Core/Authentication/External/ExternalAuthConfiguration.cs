using System.Collections.Generic;
using Abp.Dependency;

namespace NoopsycheEMSProductionManagementSystem.Authentication.External
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ExternalAuthConfiguration : IExternalAuthConfiguration, ISingletonDependency
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public List<ExternalLoginProviderInfo> Providers { get; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public ExternalAuthConfiguration()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            Providers = new List<ExternalLoginProviderInfo>();
        }
    }
}
