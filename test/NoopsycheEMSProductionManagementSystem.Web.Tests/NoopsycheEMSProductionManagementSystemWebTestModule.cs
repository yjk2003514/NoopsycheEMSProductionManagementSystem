using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NoopsycheEMSProductionManagementSystem.EntityFrameworkCore;
using NoopsycheEMSProductionManagementSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NoopsycheEMSProductionManagementSystem.Web.Tests
{
    [DependsOn(
        typeof(NoopsycheEMSProductionManagementSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NoopsycheEMSProductionManagementSystemWebTestModule : AbpModule
    {
        public NoopsycheEMSProductionManagementSystemWebTestModule(NoopsycheEMSProductionManagementSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NoopsycheEMSProductionManagementSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NoopsycheEMSProductionManagementSystemWebMvcModule).Assembly);
        }
    }
}