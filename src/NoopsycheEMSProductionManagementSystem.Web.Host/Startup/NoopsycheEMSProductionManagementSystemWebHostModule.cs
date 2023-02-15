using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NoopsycheEMSProductionManagementSystem.Configuration;

namespace NoopsycheEMSProductionManagementSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(NoopsycheEMSProductionManagementSystemWebCoreModule))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class NoopsycheEMSProductionManagementSystemWebHostModule: AbpModule
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public NoopsycheEMSProductionManagementSystemWebHostModule(IWebHostEnvironment env)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override void Initialize()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            IocManager.RegisterAssemblyByConvention(typeof(NoopsycheEMSProductionManagementSystemWebHostModule).GetAssembly());
        }
    }
}
