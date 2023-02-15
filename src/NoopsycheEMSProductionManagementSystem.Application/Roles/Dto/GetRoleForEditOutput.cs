using System.Collections.Generic;

namespace NoopsycheEMSProductionManagementSystem.Roles.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class GetRoleForEditOutput
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public RoleEditDto Role { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public List<FlatPermissionDto> Permissions { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public List<string> GrantedPermissionNames { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}