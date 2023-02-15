using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace NoopsycheEMSProductionManagementSystem.Authorization.Accounts.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class IsTenantAvailableInput
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string TenancyName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
