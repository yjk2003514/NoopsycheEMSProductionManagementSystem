using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using NoopsycheEMSProductionManagementSystem.EntityFrameworkCore.Seed;

namespace NoopsycheEMSProductionManagementSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(NoopsycheEMSProductionManagementSystemCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class NoopsycheEMSProductionManagementSystemEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<NoopsycheEMSProductionManagementSystemDbContext>(options =>
                {
                    //ExistingConnection 是一个已经存在的数据库连接
                    if (options.ExistingConnection != null)
                    {
                        NoopsycheEMSProductionManagementSystemDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        NoopsycheEMSProductionManagementSystemDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NoopsycheEMSProductionManagementSystemEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
