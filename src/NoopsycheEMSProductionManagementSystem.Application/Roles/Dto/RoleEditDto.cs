using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Roles;
using NoopsycheEMSProductionManagementSystem.Authorization.Roles;

namespace NoopsycheEMSProductionManagementSystem.Roles.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class RoleEditDto: EntityDto<int>
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [Required]
        [StringLength(AbpRoleBase.MaxNameLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [Required]
        [StringLength(AbpRoleBase.MaxDisplayNameLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string DisplayName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [StringLength(Role.MaxDescriptionLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Description { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public bool IsStatic { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}