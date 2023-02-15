using System.Linq;
using AutoMapper;
using Abp.Authorization;
using Abp.Authorization.Roles;
using NoopsycheEMSProductionManagementSystem.Authorization.Roles;

namespace NoopsycheEMSProductionManagementSystem.Roles.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class RoleMapProfile : Profile
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public RoleMapProfile()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            // Role and permission
            CreateMap<Permission, string>().ConvertUsing(r => r.Name);
            CreateMap<RolePermissionSetting, string>().ConvertUsing(r => r.Name);

            CreateMap<CreateRoleDto, Role>();

            CreateMap<RoleDto, Role>();

            CreateMap<Role, RoleDto>().ForMember(x => x.GrantedPermissions,
                opt => opt.MapFrom(x => x.Permissions.Where(p => p.IsGranted)));

            CreateMap<Role, RoleListDto>();
            CreateMap<Role, RoleEditDto>();
            CreateMap<Permission, FlatPermissionDto>();
        }
    }
}
