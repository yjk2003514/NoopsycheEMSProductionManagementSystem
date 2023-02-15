using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NoopsycheEMSProductionManagementSystem.Controllers
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public abstract class NoopsycheEMSProductionManagementSystemControllerBase: AbpController
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected NoopsycheEMSProductionManagementSystemControllerBase()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            LocalizationSourceName = NoopsycheEMSProductionManagementSystemConsts.LocalizationSourceName;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        protected void CheckErrors(IdentityResult identityResult)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
