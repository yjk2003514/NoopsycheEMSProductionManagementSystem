using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NoopsycheEMSProductionManagementSystem.Authorization;

namespace NoopsycheEMSProductionManagementSystem
{
    [DependsOn(
        typeof(NoopsycheEMSProductionManagementSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class NoopsycheEMSProductionManagementSystemApplicationModule : AbpModule
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override void PreInitialize()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            Configuration.Authorization.Providers.Add<NoopsycheEMSProductionManagementSystemAuthorizationProvider>();
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override void Initialize()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            var thisAssembly = typeof(NoopsycheEMSProductionManagementSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
