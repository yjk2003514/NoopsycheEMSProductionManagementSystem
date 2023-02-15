using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace NoopsycheEMSProductionManagementSystem.Configuration
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public static class HostingEnvironmentExtensions
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public static IConfigurationRoot GetAppConfiguration(this IWebHostEnvironment env)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}
