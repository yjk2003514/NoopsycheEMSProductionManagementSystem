using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;
using NoopsycheEMSProductionManagementSystem.MultiTenancy;

namespace NoopsycheEMSProductionManagementSystem
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class NoopsycheEMSProductionManagementSystemAppServiceBase : ApplicationService
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public TenantManager TenantManager { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public UserManager UserManager { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected NoopsycheEMSProductionManagementSystemAppServiceBase()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            LocalizationSourceName = NoopsycheEMSProductionManagementSystemConsts.LocalizationSourceName;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected virtual async Task<User> GetCurrentUserAsync()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }
          
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected virtual Task<Tenant> GetCurrentTenantAsync()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected virtual void CheckErrors(IdentityResult identityResult)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
