using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Authorization;

namespace NoopsycheEMSProductionManagementSystem.Roles.Dto
{
    [AutoMapFrom(typeof(Permission))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class PermissionDto : EntityDto<long>
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string DisplayName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Description { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
