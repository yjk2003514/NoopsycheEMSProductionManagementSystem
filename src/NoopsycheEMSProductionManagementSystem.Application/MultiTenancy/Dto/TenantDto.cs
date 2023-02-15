using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.MultiTenancy;

namespace NoopsycheEMSProductionManagementSystem.MultiTenancy.Dto
{
    [AutoMapFrom(typeof(Tenant))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TenantDto : EntityDto
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        [RegularExpression(AbpTenantBase.TenancyNameRegex)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string TenancyName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [Required]
        [StringLength(AbpTenantBase.MaxNameLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; set; }        
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public bool IsActive {get; set;}
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
