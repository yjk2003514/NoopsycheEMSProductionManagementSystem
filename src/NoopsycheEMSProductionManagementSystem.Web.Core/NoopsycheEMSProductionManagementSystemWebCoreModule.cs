using System;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.AspNetCore.SignalR;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.Configuration;
using NoopsycheEMSProductionManagementSystem.Authentication.JwtBearer;
using NoopsycheEMSProductionManagementSystem.Configuration;
using NoopsycheEMSProductionManagementSystem.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace NoopsycheEMSProductionManagementSystem
{
    [DependsOn(
         typeof(NoopsycheEMSProductionManagementSystemApplicationModule),
         typeof(NoopsycheEMSProductionManagementSystemEntityFrameworkModule),
         typeof(AbpAspNetCoreModule)
        ,typeof(AbpAspNetCoreSignalRModule)
     )]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class NoopsycheEMSProductionManagementSystemWebCoreModule : AbpModule
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public NoopsycheEMSProductionManagementSystemWebCoreModule(IWebHostEnvironment env)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override void PreInitialize()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                NoopsycheEMSProductionManagementSystemConsts.ConnectionStringName
            );

            // Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Modules.AbpAspNetCore()
                 .CreateControllersForAppServices(
                     typeof(NoopsycheEMSProductionManagementSystemApplicationModule).GetAssembly()
                 );

            ConfigureTokenAuth();
        }

        private void ConfigureTokenAuth()
        {
            IocManager.Register<TokenAuthConfiguration>();
            var tokenAuthConfig = IocManager.Resolve<TokenAuthConfiguration>();

            tokenAuthConfig.SecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appConfiguration["Authentication:JwtBearer:SecurityKey"]));
            tokenAuthConfig.Issuer = _appConfiguration["Authentication:JwtBearer:Issuer"];
            tokenAuthConfig.Audience = _appConfiguration["Authentication:JwtBearer:Audience"];
            tokenAuthConfig.SigningCredentials = new SigningCredentials(tokenAuthConfig.SecurityKey, SecurityAlgorithms.HmacSha256);
            tokenAuthConfig.Expiration = TimeSpan.FromDays(1);
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override void Initialize()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            IocManager.RegisterAssemblyByConvention(typeof(NoopsycheEMSProductionManagementSystemWebCoreModule).GetAssembly());
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public override void PostInitialize()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NoopsycheEMSProductionManagementSystemWebCoreModule).Assembly);
        }
    }
}
